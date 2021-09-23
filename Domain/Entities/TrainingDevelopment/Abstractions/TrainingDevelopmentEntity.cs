using Domain.Entities.TrainingDevelopment.Abstractions.Content;
using Domain.Entities.TrainingDevelopment.Abstractions.CustomFields;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Abstractions
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