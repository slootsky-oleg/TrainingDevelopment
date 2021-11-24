using Bks.Domain.Repositories;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment;

namespace Bks.Packages.TrainingDevelopment.Domain.Repositories
{
    public interface ITrainingEntityRepository<T>: IEntityRepository<T>
        where T: TrainingEntity
    {
        
    }
}