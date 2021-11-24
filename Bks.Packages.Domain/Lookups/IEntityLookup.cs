using System;
using System.Threading.Tasks;

namespace Bks.Fox.Domain.Lookups
{
    public interface IEntityLookup<T>
    {
        Task<T> GetRequired(Guid id);
    }
}