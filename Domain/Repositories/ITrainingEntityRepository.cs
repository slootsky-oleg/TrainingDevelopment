using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.Training.Development.Domain.Repositories
{
    public interface ITrainingEntityRepository<T>
        where T: ITrainingEntity
    {
        Task<T> GetAsync(Guid id);
        Task<IReadOnlyCollection<T>> BatchGetAsync(Guid id);
        void Add(T entity);

    }
}