using Domain.Entities.TrainingDevelopment.Behaviour.Content;
using Domain.Entities.TrainingDevelopment.Behaviour.CustomFields;
using Domain.Entities.TrainingDevelopment.Behaviour.Versioning;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class TrainingDevelopmentEntity : ITrainingDevelopmentEntity, IHasCustomFields, IHasContent, IVersioned
    {
        public GuidId Id { get; }
        public Version Version_Q { get; }
        public ExternalId ExternalId { get; }
        public Description Description { get; }
        public Name Name { get; }

        //Common for all training dev entities
        public CustomFieldContainer CustomFields_Q { get; }
        public ContentContainer_Q Content_Q { get; }
    }

}