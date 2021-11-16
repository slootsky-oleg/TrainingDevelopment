using System.Collections.Generic;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingCollection<T>
        where T : ITrainingEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems();
    }
}