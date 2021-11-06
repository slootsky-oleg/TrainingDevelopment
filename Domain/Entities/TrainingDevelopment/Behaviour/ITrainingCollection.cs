using System.Collections.Generic;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingCollection<T>
        where T : ITrainingEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems();
    }
}