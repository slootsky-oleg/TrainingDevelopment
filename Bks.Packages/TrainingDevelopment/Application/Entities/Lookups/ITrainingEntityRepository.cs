using Bks.Packages.Core.Domain.Repositories;
using Bks.Packages.TrainingDevelopment.Domain.Entities;

namespace Bks.Packages.TrainingDevelopment.Application.Entities.Lookups
{
    public interface ITrainingEntityRepository<T>: IEntityRepository<T>
        where T: ITrainingEntityConcrete
    {
        
    }
}