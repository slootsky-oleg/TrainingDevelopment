using Domain.Entities.TrainingDevelopment.Behaviour.Content;
using Domain.Entities.TrainingDevelopment.Behaviour.CustomFields;
using Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.Operational.Scheduling
{
    //TODO: Find a better name
    public abstract class SchedulableEntity
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

        
        #region availability
        
        //Sounds like state machine that can be handled with only two methods  - push down / up
        //Active-Deprecated-Obsolete-Archived

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
        public DateRange DateRange { get; set; }
        public LocationId LocationId { get; set; }
        public ParticipantContainer Participants { get; set; }

        public ResourceContainer Resources { get; set; }
    }
}