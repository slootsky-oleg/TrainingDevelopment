using System;
using System.Threading;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Repositories.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;
using MediatR;
using ReflectionMagic;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementHandler : IRequestHandler<AddTaskResourceRequirementRequest, AddTaskResourceRequirementResponse>
    {
        private readonly ITaskRepository repository;

        public AddTaskResourceRequirementHandler(ITaskRepository repository)
        {
            this.repository = repository;
        }

        public async Task<AddTaskResourceRequirementResponse> Handle(AddTaskResourceRequirementRequest request, CancellationToken cancellationToken)
        {
            var task = await repository.GetAsync(request.EntityId)
                       ?? throw new Exception("Not found");

            var typeId = GuidId.Of(request.TypeId);
            var requirement = new ResourceRequirement(typeId, request.Quantity);

            //resolve from context. Use generic Request<T> or context provider
            var userId = GuidId.New();
            var audit = new AuditRecord(userId, DateTime.Now);
            task.ResourceRequirements.Add(audit, requirement);
            
            //await repository.CommitAsync();


            return new AddTaskResourceRequirementResponse(requirement);
        }
    }
}