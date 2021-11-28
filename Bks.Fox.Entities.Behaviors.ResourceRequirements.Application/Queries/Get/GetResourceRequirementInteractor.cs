using System;
using System.Threading.Tasks;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.Common;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Services;
using Bks.Fox.Behaviors.ResourceRequirements.Domain;
using Bks.Fox.Domain.Values.Ids;
using Bks.Fox.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Fox.TrainingDevelopment.Domain.Entities;
using Bks.Fox.TrainingDevelopment.Domain.Repositories;

namespace Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.Get
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

            //return new GetResourceRequirementResponse(requirement);
            throw new NotImplementedException();
        }
    }
}