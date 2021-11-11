﻿using Bks.Packages.Domain.Aggregates;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities
{
    public interface IHasRelatedEntities<T>
        where T : AggregateRoot
    {
        public RelatedEntityContainer<T> RelatedEntities { get; }
    }
}