using System.Collections.Generic;

namespace Bks.Fox.Domain.TrainingDevelopment.TODO.Behaviour
{
    public interface ITrainingCollection<T>
        where T : TrainingEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems();
    }
}