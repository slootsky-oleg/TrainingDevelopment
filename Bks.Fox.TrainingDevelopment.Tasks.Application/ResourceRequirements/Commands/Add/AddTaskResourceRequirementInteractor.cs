using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Services;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementInteractor
    {
        private readonly ITaskRepository repository;
        private readonly IResourceRequirementRuleValidator ruleValidator;

        public AddTaskResourceRequirementInteractor(
            ITaskRepository repository,
            IResourceRequirementRuleValidator ruleValidator
            )
        {
            this.repository = repository;
            this.ruleValidator = ruleValidator;
        }

        public async Task<AddTaskResourceRequirementResponse> Execute(
            UserFootprint footprint,
            Guid taskId,
            AddTaskResourceRequirementRequest request)
        {
            var task = await repository.GetAsync(taskId)
                       ?? throw new Exception("Not found");

            await ruleValidator.ValidateEnabled(task.TypeId);

            var typeId = GuidId.Of(request.TypeId);
            var requirement = new ResourceRequirement(typeId, request.Quantity);

            task.AddResourceRequirement(footprint, requirement);
            
            //await repository.CommitAsync();


            return new AddTaskResourceRequirementResponse(requirement);
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