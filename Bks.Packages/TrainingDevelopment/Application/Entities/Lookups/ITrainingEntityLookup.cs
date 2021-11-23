using System;
using System.Threading.Tasks;
using Bks.Packages.Core.Domain.Entities;

namespace Bks.Packages.TrainingDevelopment.Application.Entities.Lookups
{
    public interface ITrainingEntityLookup<T>
        where T: TrainingEntity
    {
        Task<T> GetRequired(Guid id);
    }
}