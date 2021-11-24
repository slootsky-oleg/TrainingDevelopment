using System.Linq;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Bks.Packages.Core.Presentation.Filters.Swagger
{
    public class FeatureGateDocumentFilter : IDocumentFilter
    {
        private readonly IFeatureManager featureManager;

        public FeatureGateDocumentFilter(IFeatureManager featureManager)
        {
            this.featureManager = featureManager;
        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (var description in context.ApiDescriptions)
            {
                var filterMetaData = GetFilterMetaData(description);
                if (filterMetaData == default)
                {
                    continue;
                }

                var featureGateAttribute = filterMetaData as FeatureGateAttribute;
                var feature = featureGateAttribute
                    .Features
                    .Single();

                var isActive = featureManager
                    .IsEnabledAsync(feature)
                    .Result;
                if (isActive)
                {
                    continue;
                }

                var descriptionPath = $"/{description.RelativePath}";
                var apiPath = swaggerDoc
                    .Paths
                    .FirstOrDefault(o => o.Key.Equals(descriptionPath));

                swaggerDoc
                    .Paths
                    .Remove(apiPath.Key);
            }
        }

        private static IFilterMetadata GetFilterMetaData(ApiDescription apiDescription)
        {
            var filterPipeline = apiDescription
                .ActionDescriptor
                .FilterDescriptors;

            var filterMetaData = filterPipeline
                .Select(filterInfo => filterInfo.Filter)
                .SingleOrDefault(filter => filter is FeatureGateAttribute);
            return filterMetaData;
        }
    }
}