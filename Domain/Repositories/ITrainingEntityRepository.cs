using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.TrainingDevelopment.Domain.Repositories
{
    public interface ITrainingEntityRepository<T>
        where T : ITrainingEntity
    {
        Task<T> GetAsync(Guid id);
        Task<IReadOnlyCollection<T>> BatchGetAsync(Guid id);
        void Add(T entity);
    }
}