using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;
using Bks.TrainingDevelopment.Domain.Repositories.TrainingDevelopment.Tasks;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementInteractor
    {
        private readonly ITaskRepository repository;

        public AddTaskResourceRequirementInteractor(ITaskRepository repository)
        {
            this.repository = repository;
        }

        public async Task<AddTaskResourceRequirementResponse> Execute(
            AuditRecord audit,
            Guid taskId,
            AddTaskResourceRequirementRequest request)
        {
            var task = await repository.GetAsync(taskId)
                       ?? throw new Exception("Not found");

            var typeId = GuidId.Of(request.TypeId);
            var requirement = new ResourceRequirement(typeId, request.Quantity);

            task.Add(audit, requirement);
            
            //await repository.CommitAsync();


            return new AddTaskResourceRequirementResponse(requirement);
        }
        
        
        // public async Task<AddTaskResourceRequirementResponse> Update(
        //     AuditRecord audit,
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