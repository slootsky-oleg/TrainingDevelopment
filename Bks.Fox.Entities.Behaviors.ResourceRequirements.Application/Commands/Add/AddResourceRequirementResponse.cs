using Bks.Fox.Entities.Behaviors.Application.Commands.Add;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;

namespace Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Commands.Add
{
    public class AddResourceRequirementResponse : AddBehaviorResponse
    {
        public AddResourceRequirementResponse(ResourceRequirement behaviour)
            : base(behaviour)
        {
        }
    }
}