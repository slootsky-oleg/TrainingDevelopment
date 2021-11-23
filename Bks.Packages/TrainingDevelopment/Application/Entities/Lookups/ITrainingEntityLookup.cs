using System;
using System.Threading.Tasks;
using Bks.Packages.TrainingDevelopment.Domain.Entities;

namespace Bks.Packages.TrainingDevelopment.Application.Entities.Lookups
{
    public interface ITrainingEntityLookup<T>
        where T: ITrainingEntityConcrete
    {
        Task<T> GetRequired(Guid id);
    }
}