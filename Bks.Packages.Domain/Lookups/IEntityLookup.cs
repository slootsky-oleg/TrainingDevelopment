using System;
using System.Threading.Tasks;

namespace Bks.Fox.Entities.Domain.Lookups
{
    public interface IEntityLookup<T>
    {
        Task<T> GetRequired(Guid id);
    }
}