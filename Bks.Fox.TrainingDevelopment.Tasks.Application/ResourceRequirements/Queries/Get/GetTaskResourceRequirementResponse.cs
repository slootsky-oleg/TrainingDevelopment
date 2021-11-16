using Bks.Packages.Core.Application.Entities.Behavior.ResourceRequirements.Queries.Get;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Queries.Get
{
    public class GetTaskResourceRequirementResponse : BaseGetResourceRequirementResponse
    {
        public GetTaskResourceRequirementResponse(ResourceRequirement requirement) : base(requirement)
        {
        }
    }
}