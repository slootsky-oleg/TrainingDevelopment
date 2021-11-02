using System.Threading;
using System.Threading.Tasks;
using Atis.Training.Development.Domain.Entities.TrainingDevelopment;
using MediatR;

namespace Atis.Training.Development.Application.Tasks.Queries.Get
{
    public class GetAtisTaskHandler : IRequestHandler<GetAtisTaskRequest, GetAtisTaskResponse>
    {
        public async Task<GetAtisTaskResponse> Handle(GetAtisTaskRequest request, CancellationToken cancellationToken)
        {
            var entity = new AtisTask();
            return new GetAtisTaskResponse(entity);
        }
    }
}