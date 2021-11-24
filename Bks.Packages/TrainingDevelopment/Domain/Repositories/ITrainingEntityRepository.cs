using Bks.Packages.Core.Domain.Entities;
using Bks.Packages.Core.Domain.Repositories;

namespace Bks.Packages.TrainingDevelopment.Application.Entities.Lookups
{
    public interface ITrainingEntityRepository<T>: IEntityRepository<T>
        where T: TrainingEntity
    {
        
    }
}