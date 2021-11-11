using System.Collections.Generic;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingCollection<T>
        where T : ITrainingEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems();
    }
}