using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Commands.Add;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Queries.Common;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Services;
using Bks.Packages.Domain.Entities;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Domain.Values.Ids;
using Bks.Packages.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Packages.TrainingDevelopment.Domain.Repositories;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Queries.Get
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