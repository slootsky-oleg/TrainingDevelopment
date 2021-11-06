using System;
using System.Threading;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;
using MediatR;
using ReflectionMagic;

namespace Bks.TrainingDevelopment.Application.Tasks.Queries.Get
{
    public class GetTaskHandler : IRequestHandler<GetTaskRequest, GetTaskResponse>
    {
        public async Task<GetTaskResponse> Handle(GetTaskRequest request, CancellationToken cancellationToken)
        {
            var task = new TrainingTask();

            var hack = task.AsDynamic();
            hack.Id = GuidId.Of(request.EntityId);
            hack.Name = Name.Of($"New task [{DateTime.Now}]");

            return new GetTaskResponse(task);
        }
    }
}