using Bks.Fox.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Domain.TODO.Behaviour.RelatedEntities
{
    public interface IHasRelatedEntities<T>
        where T : AggregateRoot
    {
        public RelatedEntityContainer<T> RelatedEntities { get; }
    }
}