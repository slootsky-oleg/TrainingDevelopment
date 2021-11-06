using Bks.TrainingDevelopment.Application.Common.Entities.Behavior.Commands.Add;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add
{
    public class AddTaskResourceRequirementResponse : AbstractAddBehaviorResponse
    {
        public AddTaskResourceRequirementResponse(ResourceRequirement behaviour) : base(behaviour)
        {
        }
    }
}