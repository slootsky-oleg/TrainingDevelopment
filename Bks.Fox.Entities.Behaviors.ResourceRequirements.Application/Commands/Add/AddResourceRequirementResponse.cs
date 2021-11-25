using Bks.Fox.Behaviors.Application.Commands.Add;
using Bks.Fox.Behaviors.ResourceRequirements.Domain;

namespace Bks.Fox.Behaviors.ResourceRequirements.Application.Commands.Add
{
    public class AddResourceRequirementResponse : AddBehaviorResponse
    {
        public AddResourceRequirementResponse(ResourceRequirement behaviour)
            : base(behaviour)
        {
        }
    }
}