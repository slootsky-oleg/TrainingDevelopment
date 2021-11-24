using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Application.Entities.Lookups
{
    public interface ITrainingEntityLookup<T>
        where T: TrainingEntity
    {
        Task<T> GetRequired(Guid id);
    }
}