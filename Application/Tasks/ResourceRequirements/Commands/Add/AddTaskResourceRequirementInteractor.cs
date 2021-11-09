using System;
using System.Threading;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Repositories.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

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
            Guid taskId,
            AddTaskResourceRequirementRequest request)
        {
            var task = await repository.GetAsync(request.EntityId)
                       ?? throw new Exception("Not found");

            var typeId = GuidId.Of(request.TypeId);
            var requirement = new ResourceRequirement(typeId, request.Quantity);

            //resolve from context. Use generic Request<T> or context provider
            var audit = new AuditRecord(1);
            //task.ResourceRequirements.Add(audit, requirement);
            
            //await repository.CommitAsync();


            return new AddTaskResourceRequirementResponse(requirement);
        }
    }
}