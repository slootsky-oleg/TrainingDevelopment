using Bks.Fox.Application.Behaviors.Commands.Add;
using Bks.Fox.Domain.Behaviors.ResourceRequirements;

namespace Bks.Fox.Application.Behaviors.ResourceRequirements.Commands.Add
{
    public class AddResourceRequirementResponse : AddBehaviorResponse
    {
        public AddResourceRequirementResponse(ResourceRequirement behaviour)
            : base(behaviour)
        {
        }
    }
}