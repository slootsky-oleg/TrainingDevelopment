using System.Collections.Generic;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingCollection<T>
        where T: ITrainingEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems_Q();
    }
}