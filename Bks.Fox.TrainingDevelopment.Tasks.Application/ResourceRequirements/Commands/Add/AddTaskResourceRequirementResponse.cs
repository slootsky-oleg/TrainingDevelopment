using Bks.Packages.Core.Application.Entities.Behaviors.Commands.Add;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementResponse : AddBehaviorResponse
    {
        public AddTaskResourceRequirementResponse(ResourceRequirement behaviour) : base(behaviour)
        {
        }
    }
}