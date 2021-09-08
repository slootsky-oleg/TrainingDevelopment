using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment
{
    public abstract class TrainingDevelopmentCollectionEntity<T> : TrainingDevelopmentEntity
        where T: TrainingDevelopmentEntity
    {
        //TODO: Choose a better name: Items, Trainings, TrainingItems...
        public abstract IReadOnlyCollection<T> GetTrainingItems();
    }
}