using Domain.Entities.TrainingDevelopment.Behaviours.Content;
using Domain.Entities.TrainingDevelopment.Behaviours.CustomFields;
using Domain.Entities.TrainingDevelopment.Behaviours.Versioning;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Behaviours
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