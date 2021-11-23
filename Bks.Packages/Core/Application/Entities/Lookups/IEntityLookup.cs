using System;
using System.Threading.Tasks;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Packages.Core.Application.Entities.Lookups
{
    public interface IEntityLookup<T>
    {
        Task<T> GetRequired(Guid id);
    }
}