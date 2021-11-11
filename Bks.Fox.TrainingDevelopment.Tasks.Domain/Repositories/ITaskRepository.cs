using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Packages.Domain.Repositories;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories
{
    public interface ITaskRepository : IEntityRepository<TrainingTask>
    {
        
    }
}