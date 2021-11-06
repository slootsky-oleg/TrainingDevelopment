namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities
{
    public class RelatedEntityContainer<T> : IHasRelatedEntities<T>
        where T : TrainingEntity
    {
        public RelatedEntityContainer<T> RelatedEntities { get; }
    }
}