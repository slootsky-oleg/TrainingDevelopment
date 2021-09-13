using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Entities.TrainingDevelopment.Containers.Resources;
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
        
        //Consider uniting with custom fields (SetId inside the custom field container)
        public EntityTypeId TypeId_Q { get; set; }

        //Does it belong to the base entity?
        public PrerequisiteContainer Prerequisites_Q { get; set; }

        //Does it belong to the base entity?
        public ResourceRequirementsContainer ResourceRequirements_Q { get; set; }

        public CustomFieldContainer CustomFields { get; set; }

        public ContentContainer_Q Content { get; set; }

        public abstract void Archive();
        public abstract void Restore();

        //TODO: Versioning
    }
}