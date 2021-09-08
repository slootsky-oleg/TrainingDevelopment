using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public GuidId Id { get; set; }
        public ExternalId ExternalId { get; set; }
        public Description Description { get; set; }
        public Name Name { get; set; }
        public EntityTypeId TypeId { get; set; }

        //TODO: Define CustomFields
        public CustomFieldsContainer CustomFieldsContainer { get; set; }

        //TODO: Define Content
        public ContentContainer ContentContainer { get; set; }
    }
}