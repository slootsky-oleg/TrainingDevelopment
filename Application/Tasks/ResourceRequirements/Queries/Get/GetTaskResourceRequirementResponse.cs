using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.TrainingDevelopment.Application.Common.Entities.Behavior.ResourceRequirements.Queries.Get;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Queries.Get
{
    public class GetTaskResourceRequirementResponse : AbstractGetResourceRequirementResponse
    {
        public GetTaskResourceRequirementResponse(ResourceRequirement requirement) : base(requirement)
        {
        }
    }
}