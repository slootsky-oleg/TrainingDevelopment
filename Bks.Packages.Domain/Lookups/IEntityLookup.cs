using System;
using System.Threading.Tasks;

namespace Bks.Practices.Ddd.Domain.Lookups
{
    public interface IEntityLookup<T>
    {
        Task<T> GetRequired(Guid id);
    }
}