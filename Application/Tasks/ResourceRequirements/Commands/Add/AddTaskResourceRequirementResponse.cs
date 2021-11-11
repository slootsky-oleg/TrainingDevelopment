using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.TrainingDevelopment.Application.Common.Entities.Behavior.Commands.Add;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementResponse : AbstractAddBehaviorResponse
    {
        public AddTaskResourceRequirementResponse(ResourceRequirement behaviour) : base(behaviour)
        {
        }
    }
}