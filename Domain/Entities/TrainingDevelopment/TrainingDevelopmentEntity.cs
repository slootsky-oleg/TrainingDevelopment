using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment
{
    //TODO: remove setters
    public abstract class TrainingDevelopmentEntity
    {
        public GuidId Id { get; set; }
        public ExternalId ExternalId { get; set; }
        public Description Description { get; set; }
        public Name Name { get; set; }
        public EntityTypeId TypeId { get; set; }

        //TODO: Define CustomFields
        public CustomFields CustomFields { get; set; }

        //TODO: Define Content
        public Content Content { get; set; }

        //TODO: Define Audience
        public TargetAudience Audience { get; set; }

        //TODO: Define ResourceRequirements
        public ResourceRequirements ResourceRequirements { get; set; }
    }
}