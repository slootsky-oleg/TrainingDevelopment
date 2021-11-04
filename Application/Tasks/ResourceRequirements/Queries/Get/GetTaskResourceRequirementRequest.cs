using Bks.TrainingDevelopment.Application.Common.Entities.Behavior.Queries.Get;
using MediatR;

namespace Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Queries.Get
{
    public class GetTaskResourceRequirementRequest : AbstractGetBehaviourRequest, IRequest<GetTaskResourceRequirementResponse>
    {
        
    }
}