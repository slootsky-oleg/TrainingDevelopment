using Bks.Packages.Application.Entities.Behavior.Commands.Add;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementResponse : AbstractAddBehaviorResponse
    {
        public AddTaskResourceRequirementResponse(ResourceRequirement behaviour) : base(behaviour)
        {
        }
    }
}