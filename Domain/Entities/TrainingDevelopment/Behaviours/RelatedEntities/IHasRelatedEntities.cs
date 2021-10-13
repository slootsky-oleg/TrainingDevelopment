namespace Domain.Entities.TrainingDevelopment.Behaviours.RelatedEntities
{
    public interface IHasRelatedEntities<T> 
        where T: ITrainingDevelopmentEntity
    {
        public RelatedEntityContainer<T> RelatedEntities_Q { get; }
    }
}