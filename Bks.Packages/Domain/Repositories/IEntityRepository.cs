using System;
using System.Threading.Tasks;
using Bks.Packages.Domain.Entities;

namespace Bks.Packages.Domain.Repositories
{
    public interface IEntityRepository<T>
        where T : AggregateRoot
    {
        Task<T> GetAsync(Guid id);
        // Task<IReadOnlyCollection<T>> BatchGetAsync(Guid id);
        // void Add(T entity);
    }
}