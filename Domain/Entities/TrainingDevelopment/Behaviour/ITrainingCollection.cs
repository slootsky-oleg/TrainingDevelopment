using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingCollection<T>
        where T: ITrainingDevelopmentEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems_Q();
    }
}