using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories;

namespace Bks.Fox.TrainingDevelopment.Tasks.Application.Queries.Get
{
    public class GetTaskInteractor
    {
        private readonly ITaskRepository repository;

        public GetTaskInteractor(ITaskRepository repository)
        {
            this.repository = repository;
        }

        public async Task<GetTaskResponse> Execute(Guid id)
        {
            var task = await repository.GetAsync(id)
                       ?? throw new Exception("Not found");
            //var task = new TrainingTask();

            // var hack = task.AsDynamic();
            // hack.Id = GuidId.Of(request.EntityId);
            // hack.Name = Name.Of($"New task [{DateTime.Now}]");

            return new GetTaskResponse(null);
        }
    }
}