using Bks.Fox.Domain.Repositories;
using Bks.Fox.TrainingDevelopment.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Domain.Repositories
{
    public interface ITrainingEntityRepository<T>: IEntityRepository<T>
        where T: TrainingEntity
    {
        
    }
}