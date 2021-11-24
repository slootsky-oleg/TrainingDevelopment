using Bks.Packages.Domain.Entities;
using Bks.Packages.Domain.Repositories;

namespace Bks.Packages.TrainingDevelopment.Domain.Repositories
{
    public interface ITrainingEntityRepository<T>: IEntityRepository<T>
        where T: TrainingEntity
    {
        
    }
}