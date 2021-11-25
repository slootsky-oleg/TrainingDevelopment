using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories;

namespace Bks.Fox.TrainingDevelopment.Tasks.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public async Task<TrainingTask> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}