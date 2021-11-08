using System;
using System.Threading;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Application.Common.Entities.Commands.Create;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Application.Tasks.Commands.Create
{
    public class CreateTaskInteractor
    {
        public async Task<CreateEntityResponse> Execute(CreateTaskRequest request)
        {
            // var task = new TrainingTask();
            //
            // var hack = task.AsDynamic();
            // hack.Id = GuidId.New();
            // hack.Name = Name.Of($"New task [{DateTime.Now}]");

            return new CreateEntityResponse(null);
        }
    }
}