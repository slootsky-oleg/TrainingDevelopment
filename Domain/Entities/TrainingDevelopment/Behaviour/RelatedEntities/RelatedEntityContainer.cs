﻿using Bks.Packages.Domain.Entities;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities
{
    public class RelatedEntityContainer<T> : IHasRelatedEntities<T>
        where T : AggregateRoot
    {
        public RelatedEntityContainer<T> RelatedEntities { get; }
    }
}