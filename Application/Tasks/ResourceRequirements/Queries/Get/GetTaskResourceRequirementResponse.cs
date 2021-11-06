using Bks.TrainingDevelopment.Application.Common.Entities.Behavior.ResourceRequirements.Queries.Get;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Queries.Get
{
    public class GetTaskResourceRequirementResponse : AbstractGetResourceRequirementResponse
    {
        public GetTaskResourceRequirementResponse(ResourceRequirement requirement) : base(requirement)
        {
        }
    }
}