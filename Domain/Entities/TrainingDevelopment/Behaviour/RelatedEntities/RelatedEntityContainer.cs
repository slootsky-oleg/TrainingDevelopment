using Bks.Fox.Entities.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities
{
    public class RelatedEntityContainer<T> : IHasRelatedEntities<T>
        where T : AggregateRoot
    {
        public RelatedEntityContainer<T> RelatedEntities { get; }
    }
}