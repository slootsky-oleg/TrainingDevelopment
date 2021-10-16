using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingCollection<T>
        where T: ITrainingEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems_Q();
    }
}