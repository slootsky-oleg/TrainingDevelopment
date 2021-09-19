using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Entities.TrainingDevelopment.Containers.Resources;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities
{
    public abstract class BaseEntity_Q
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

        
        #region deactivation
        //Sounds like state machine that can be handled only with two methods  - push down / up

        public virtual void Activate_Q()
        {
        }

        public virtual void Deprecate_Q()
        {
        }

        public virtual void Obsolete_Q()
        {
        }
        
        public virtual void Archive_Q()
        {
        }
        #endregion

        // //Restore to a specific step or always to a previous. Consider using dedicated methods
        // public virtual void Restore_Q()
        // {
        // }

        //TODO: Versioning
    }
}