using System;
using System.Threading.Tasks;

namespace Bks.Packages.Core.Application.Entities.Lookups
{
    public interface IEntityLookup<T>
    {
        Task<T> GetRequired(Guid id);
    }
}