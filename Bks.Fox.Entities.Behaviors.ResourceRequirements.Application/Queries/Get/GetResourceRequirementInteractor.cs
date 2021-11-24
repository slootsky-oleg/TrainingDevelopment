using System;
using System.Threading.Tasks;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Queries.Common;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Services;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment;
using Bks.Packages.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Packages.TrainingDevelopment.Domain.Repositories;
using Bks.Practices.Ddd.Domain.Values.Ids;

namespace Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Queries.Get
{
    public class GetResourceRequirementInteractor<T>
        where T : TrainingEntity
    {
        private readonly ITrainingEntityLookup<T> lookup;

        public GetResourceRequirementInteractor(
            ITrainingEntityRepository<T> repository,
            ITrainingEntityLookup<T> lookup,
            IResourceRequirementRuleValidator<T> ruleValidator
            )
        {
            this.lookup = lookup;
        }

        public async Task<GetResourceRequirementResponse> Execute(Guid entityId, Guid requirementId)
        {
            var entity = await lookup.GetRequired(entityId);
            var requirementGuidId = GuidId.Of(requirementId);

            var requirement = entity
                .ResourceRequirements
                .GetRequired(requirementGuidId);

            return new GetResourceRequirementResponse(requirement);
        }
    }
}