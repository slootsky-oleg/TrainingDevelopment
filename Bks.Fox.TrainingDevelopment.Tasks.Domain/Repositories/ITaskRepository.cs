using Bks.Fox.TrainingDevelopment.Domain.Repositories;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories
{
    public interface ITaskRepository : ITrainingEntityRepository<TrainingTask>
    {
        
    }
}