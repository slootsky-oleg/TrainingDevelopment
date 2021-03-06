using System;
using System.Threading.Tasks;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Services;
using Bks.Fox.Behaviors.ResourceRequirements.Domain;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;
using Bks.Fox.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Fox.TrainingDevelopment.Domain.Entities;
using Bks.Fox.TrainingDevelopment.Domain.Repositories;

namespace Bks.Fox.Behaviors.ResourceRequirements.Application.Commands.Add
{
    public class AddResourceRequirementInteractor<T>
        where T : TrainingEntity
    {
        private readonly ITrainingEntityRepository<T> repository;
        private readonly ITrainingEntityLookup<T> lookup;
        private readonly IResourceRequirementRuleValidator<T> ruleValidator;

        public AddResourceRequirementInteractor(
            ITrainingEntityRepository<T> repository,
            ITrainingEntityLookup<T> lookup,
            IResourceRequirementRuleValidator<T> ruleValidator
            )
        {
            this.repository = repository;
            this.lookup = lookup;
            this.ruleValidator = ruleValidator;
        }

        public async Task<AddResourceRequirementResponse> Execute(
            UserFootprint footprint,
            Guid id,
            AddResourceRequirementRequest request)
        {
            // var entity = await lookup.GetRequired(id);
            //
            // //await ruleValidator.ValidateEnabled(entity.TypeId);
            //
            // var typeId = GuidId.Of(request.TypeId);
            // var requirement = new ResourceRequirement(typeId, request.Quantity);
            //
            // entity.AddResourceRequirement(footprint, requirement);
            //
            // //await repository.CommitAsync();
            //
            //
            // return new AddResourceRequirementResponse(requirement);
            throw new NotImplementedException();
        }
    }
}