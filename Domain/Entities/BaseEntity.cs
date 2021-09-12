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
        
        //TODO: consider replacing with a custom field set id inside the custom field container
        public EntityTypeId TypeId { get; set; }

        //TODO: Define CustomFields
        public CustomFieldContainer CustomFields { get; set; }

        //TODO: Define Content
        public ContentContainer Content { get; set; }

        public abstract void Archive();
        public abstract void Restore();

        //TODO: Versioning
    }
}