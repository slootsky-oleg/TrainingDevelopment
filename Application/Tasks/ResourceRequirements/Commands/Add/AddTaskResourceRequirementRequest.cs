using Bks.TrainingDevelopment.Application.Common.Entities.Behavior.ResourceRequirements.Commands.Add;
using MediatR;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementRequest :
        AbstractAddResourceRequirementRequest,
        IRequest<AddTaskResourceRequirementResponse>
    {
    }
}