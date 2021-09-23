using Domain.Entities.TrainingDevelopment.BuilingBlocks.Content;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.CustomFields;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.BuilingBlocks
{
    public abstract class TrainingDevelopmentEntity : ITrainingDevelopmentEntity, IHasCustomFields, IHasContent
    {
        public GuidId Id { get; set; }
        public Version Version { get; set; }
        public ExternalId ExternalId { get; set; }
        public Description Description { get; set; }
        public Name Name { get; set; }

        //Common for all training dev entities
        public CustomFieldContainer CustomFields { get; }
        public ContentContainer_Q Content_Q { get; }
    }

}