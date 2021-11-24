using System;
using System.Threading.Tasks;
using Bks.Fox.Application.Behaviors.ResourceRequirements.Queries.Common;
using Bks.Fox.Application.Behaviors.ResourceRequirements.Services;
using Bks.Fox.Domain.Behaviors.ResourceRequirements;
using Bks.Fox.Domain.TrainingDevelopment;
using Bks.Fox.Domain.Values.Ids;
using Bks.Packages.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Packages.TrainingDevelopment.Domain.Repositories;

namespace Bks.Fox.Application.Behaviors.ResourceRequirements.Queries.Get
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