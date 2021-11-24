using Bks.Fox.Domain.Entities;

namespace Bks.Fox.Domain.TrainingDevelopment.TODO.Behaviour.RelatedEntities
{
    public interface IHasRelatedEntities<T>
        where T : AggregateRoot
    {
        public RelatedEntityContainer<T> RelatedEntities { get; }
    }
}