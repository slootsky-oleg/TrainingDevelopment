using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Queries.Common;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Services;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment;
using Bks.Packages.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Packages.TrainingDevelopment.Domain.Repositories;

namespace Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Queries.GetAll
{
    public class GetAllResourceRequirementsInteractor<T>
        where T : TrainingEntity
    {
        private readonly ITrainingEntityLookup<T> lookup;

        public GetAllResourceRequirementsInteractor(
            ITrainingEntityRepository<T> repository,
            ITrainingEntityLookup<T> lookup,
            IResourceRequirementRuleValidator<T> ruleValidator
            )
        {
            this.lookup = lookup;
        }

        public async Task<IList<GetResourceRequirementResponse>> Execute(Guid entityId)
        {
            var entity = await lookup.GetRequired(entityId);

            return Enumerable.ToList<GetResourceRequirementResponse>(entity
                    .ResourceRequirements
                    .Select(r => new GetResourceRequirementResponse(r)));
        }
    }
}