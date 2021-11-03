using Bks.TrainingDevelopment.Application.Common.Queries.Get;
using MediatR;

namespace Bks.TrainingDevelopment.Application.Tasks.Queries.Get
{
    public class GetTaskRequest : AbstractGetEntityRequest, IRequest<GetTaskResponse>
    {
        
    }
}