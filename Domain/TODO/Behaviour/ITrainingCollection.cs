using System.Collections.Generic;
using Bks.Fox.TrainingDevelopment.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Domain.TODO.Behaviour
{
    public interface ITrainingCollection<T>
        where T : TrainingEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems();
    }
}