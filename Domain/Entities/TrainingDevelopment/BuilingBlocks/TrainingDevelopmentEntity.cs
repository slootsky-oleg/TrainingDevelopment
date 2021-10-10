using Domain.Entities.TrainingDevelopment.BuilingBlocks.Content;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.CustomFields;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.Versioning;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.BuilingBlocks
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