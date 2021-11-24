using Bks.Fox.Domain.Repositories;
using Bks.Fox.Domain.TrainingDevelopment;

namespace Bks.Packages.TrainingDevelopment.Domain.Repositories
{
    public interface ITrainingEntityRepository<T>: IEntityRepository<T>
        where T: TrainingEntity
    {
        
    }
}