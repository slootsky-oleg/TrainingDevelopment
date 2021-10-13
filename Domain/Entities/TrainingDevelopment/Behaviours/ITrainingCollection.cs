using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment.Behaviours
{
    public interface ITrainingCollection<T>
        where T: ITrainingDevelopmentEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems_Q();
    }
}