using Bks.Packages.Core.Application.Entities.Behaviors.Commands.Add;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Commands.Add
{
    public class AddResourceRequirementResponse : AddBehaviorResponse
    {
        public AddResourceRequirementResponse(ResourceRequirement behaviour) : base(behaviour)
        {
        }
    }
}