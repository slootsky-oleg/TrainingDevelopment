using System;
using System.Threading.Tasks;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Queries.Get
{
    public class GetTaskResourceRequirementInteractor
    {
        public async Task<GetTaskResourceRequirementResponse> Execute(Guid taskId, Guid requirementId)
        {
            return null;
            // var requirement = new ResourceRequirement();
            // var hack = requirement.AsDynamic();
            // hack.Id = GuidId.New();
            //
            // return new GetTaskResourceRequirementResponse(requirement);
        }
    }
}