using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;
using Bks.Packages.Core.Application.Entities.Behaviors.Commands.Add;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Commands.Add
{
    public class AddResourceRequirementResponse : AddBehaviorResponse
    {
        public AddResourceRequirementResponse(ResourceRequirement behaviour) : base(behaviour)
        {
        }
    }
}