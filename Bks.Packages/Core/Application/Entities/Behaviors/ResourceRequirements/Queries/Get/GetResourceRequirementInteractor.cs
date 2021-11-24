using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Commands.Add;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Services;
using Bks.Packages.Core.Domain.Entities;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;
using Bks.Packages.TrainingDevelopment.Application.Entities.Lookups;

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

        public async Task<IList<GetResourceRequirementResponse>> Execute(Guid id)
        {
            var entity = await lookup.GetRequired(id);

            return entity
                .ResourceRequirements
                .Select(r => new GetResourceRequirementResponse(r))
                .ToList();
        }
    }
}