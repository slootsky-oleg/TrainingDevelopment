using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities.TrainingDevelopment.Behaviour;

namespace Domain.Repositories
{
    public interface ITrainingEntityRepository<T>
        where T: ITrainingEntity
    {
        Task<T> GetAsync(Guid id);
        Task<IReadOnlyCollection<T>> BatchGetAsync(Guid id);
        void Add(T entity);

    }
}