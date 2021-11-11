using System;
using System.Threading;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Queries.Get
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