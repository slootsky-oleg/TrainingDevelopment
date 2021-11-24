using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment;
using Bks.Practices.Ddd.Domain.Repositories;

namespace Bks.Packages.TrainingDevelopment.Domain.Repositories
{
    public interface ITrainingEntityRepository<T>: IEntityRepository<T>
        where T: TrainingEntity
    {
        
    }
}