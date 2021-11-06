using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Content;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.CustomFields;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.Operational.Scheduling
{
    //TODO: Find a better name
    public abstract class SchedulableEntity
    {
        public GuidId Id { get; set; }
        public ExternalId ExternalId { get; set; }
        public Description Description { get; set; }
        public Name Name { get; set; }

        //Consider uniting with custom fields (SetId inside the custom field container)
        public EntityTypeId TypeId { get; set; }

        //Does it belong to the base entity?
        public PrerequisiteContainer Prerequisites { get; set; }

        //Does it belong to the base entity?
        public ResourceRequirementsContainer<ResourceRequirement> ResourceRequirements { get; set; }

        public CustomFieldContainer CustomFields { get; set; }

        public ContentContainer Content { get; set; }


        #region availability

        //Sounds like state machine that can be handled with only two methods  - push down / up
        //Active-Deprecated-Obsolete-Archived

        public virtual void Activate()
        {
        }

        public virtual void Deprecate()
        {
        }

        public virtual void Obsolete()
        {
        }

        public virtual void Archive()
        {
        }

        #endregion

        // //Restore to a specific step or always to a previous. Consider using dedicated methods
        // public virtual void Restore()
        // {
        // }

        //TODO: Versioning
        public DateRange DateRange { get; set; }
        public LocationId LocationId { get; set; }
        public ParticipantContainer Participants { get; set; }

        public ResourceContainer Resources { get; set; }
    }
}