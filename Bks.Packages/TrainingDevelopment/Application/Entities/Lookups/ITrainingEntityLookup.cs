using System;
using System.Threading.Tasks;
using Bks.Packages.TrainingDevelopment.Domain.Entities;

namespace Bks.Packages.TrainingDevelopment.Application.Entities.Lookups
{
    public interface ITrainingEntityLookup<T>
        where T: ITrainingDevelopmentEntity
    {
        Task<T> GetRequired(Guid id);
    }
}