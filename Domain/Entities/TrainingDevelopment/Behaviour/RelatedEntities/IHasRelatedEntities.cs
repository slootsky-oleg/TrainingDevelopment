﻿namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities
{
    public interface IHasRelatedEntities<T> 
        where T: ITrainingEntity
    {
        public RelatedEntityContainer<T> RelatedEntities_Q { get; }
    }
}