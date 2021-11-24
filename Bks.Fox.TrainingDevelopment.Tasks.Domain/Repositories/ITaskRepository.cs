using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Practices.Ddd.Domain.Repositories;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories
{
    public interface ITaskRepository : IEntityRepository<TrainingTask>
    {
        
    }
}