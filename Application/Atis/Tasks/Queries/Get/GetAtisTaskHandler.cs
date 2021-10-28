using System.Threading;
using System.Threading.Tasks;
using Bks.Training.Development.Domain.Atis.Entities.TrainingDevelopment;
using MediatR;

namespace Bks.Training.Development.Application.Atis.Tasks.Queries.Get
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