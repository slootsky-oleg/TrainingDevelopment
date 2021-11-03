using System;
using System.Threading;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Commands;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;
using MediatR;
using ReflectionMagic;

namespace Bks.TrainingDevelopment.Application.Tasks.Commands.Create
{
    public class CreateTaskHandler : IRequestHandler<CreateTaskRequest, CreateEntityResponse>
    {
        public async Task<CreateEntityResponse> Handle(CreateTaskRequest request, CancellationToken cancellationToken)
        {
            var task = new TrainingTask();
            
            var hack = task.AsDynamic();
            hack.Id = GuidId.New();
            hack.Name = Name.Of($"New task [{DateTime.Now}]");

            return new CreateEntityResponse(task);
        }
    }
}