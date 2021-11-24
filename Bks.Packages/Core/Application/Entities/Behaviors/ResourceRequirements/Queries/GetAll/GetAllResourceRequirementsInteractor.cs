using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Queries.Common;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Services;
using Bks.Packages.Core.Domain.Entities;
using Bks.Packages.TrainingDevelopment.Application.Entities.Lookups;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Queries.GetAll
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

            return entity
                .ResourceRequirements
                .Select(r => new GetResourceRequirementResponse(r))
                .ToList();
        }
    }
}