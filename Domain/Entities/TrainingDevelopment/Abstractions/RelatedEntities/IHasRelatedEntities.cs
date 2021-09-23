namespace Domain.Entities.TrainingDevelopment.Abstractions.RelatedEntities
{
    public interface IHasRelatedEntities<T> 
        where T: ITrainingDevelopmentEntity
    {
        public RelatedEntityContainer<T> RelatedEntities_Q { get; }
    }
}