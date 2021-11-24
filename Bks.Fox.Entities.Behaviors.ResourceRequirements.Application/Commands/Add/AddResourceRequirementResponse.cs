using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;
using Bks.Packages.Core.Application.Entities.Behaviors.Commands.Add;

namespace Bks.Fox.Entities.Behaviors.ResourceRequirements.Application.Commands.Add
{
    public class AddResourceRequirementResponse : AddBehaviorResponse
    {
        public AddResourceRequirementResponse(ResourceRequirement behaviour) : base(behaviour)
        {
        }
    }
}