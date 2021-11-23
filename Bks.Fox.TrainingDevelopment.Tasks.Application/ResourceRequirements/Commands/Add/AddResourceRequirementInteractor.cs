using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Services;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Commands.Add;
using Bks.Packages.Core.Application.Entities.Lookups;
using Bks.Packages.Core.Domain.Entities;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Core.Domain.Repositories;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;
using Bks.Packages.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Packages.TrainingDevelopment.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Commands.Add
{
    public class AddResourceRequirementInteractor<T>
        where T : ITrainingEntityConcrete
    {
        private readonly IEntityRepository<T> repository;
        private readonly ITrainingEntityLookup<T> lookup;
        private readonly IResourceRequirementRuleValidator<T> ruleValidator;

        public AddResourceRequirementInteractor(
            IEntityRepository<T> repository,
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
            var entity = await lookup.GetRequired(id);

            //await ruleValidator.ValidateEnabled(entity.TypeId);

            var typeId = GuidId.Of(request.TypeId);
            var requirement = new ResourceRequirement(typeId, request.Quantity);

            entity.AddResourceRequirement(footprint, requirement);
            
            //await repository.CommitAsync();


            return new AddResourceRequirementResponse(requirement);
        }
        
        
        // public async Task<AddTaskResourceRequirementResponse> Update(
        //     AuditRecord footprint,
        //     Guid taskId,
        //     GuidId reqId)
        // {
        //     var task = await repository.GetAsync(taskId)
        //                ?? throw new Exception("Not found");
        //
        //     var requirement = task.ResourceRequirements.SingleOrDefault(x => x.Id == reqId);
        //
        //     requirement.SetQuantity(quantity: 6);
        //     
        //     //await repository.CommitAsync();
        //
        //
        //     return new AddTaskResourceRequirementResponse(requirement);
        // }
    }
}