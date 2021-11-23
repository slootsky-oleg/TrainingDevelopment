using System;
using System.Threading.Tasks;
using Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Queries.Get;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Queries.Get
{
    public class GetTaskResourceRequirementInteractor
    {
        public async Task<GetResourceRequirementResponse> Execute(Guid taskId, Guid requirementId)
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