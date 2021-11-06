using System.Threading;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Values.Ids;
using MediatR;
using ReflectionMagic;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementHandler : IRequestHandler<AddTaskResourceRequirementRequest, AddTaskResourceRequirementResponse>
    {
        public async Task<AddTaskResourceRequirementResponse> Handle(AddTaskResourceRequirementRequest request, CancellationToken cancellationToken)
        {
            /*var task = taskLookup.GetOrThrow(request.Id)
            
            var addCommand = new AddResourceRequirementCommand(...);

            var requirement = task.ResourceRequirements.Add(addCommand);

            await repository.CommitAsync();

            return new AddTaskResourceRequirementResponse(requirement)
            */

            var requirement = new ResourceRequirement();
            var hack = requirement.AsDynamic();
            hack.Id = GuidId.New();

            return new AddTaskResourceRequirementResponse(requirement);
        }
    }
}