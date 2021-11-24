using System;
using System.Threading.Tasks;
using Bks.Packages.Core.Domain.Entities;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Packages.Core.Domain.Repositories
{
    public interface IEntityRepository<T>
    {
        Task<T> GetAsync(Guid id);
        // Task<IReadOnlyCollection<T>> BatchGetAsync(Guid id);
        // void Add(T entity);
    }
}