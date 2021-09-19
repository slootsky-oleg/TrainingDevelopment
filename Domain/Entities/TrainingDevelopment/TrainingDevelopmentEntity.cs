﻿using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Entities.TrainingDevelopment.Containers.Resources;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment
{
    public abstract class TrainingDevelopmentEntity
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

        public TargetAudienceContainer TargetAudience { get; set; }

        public EvaluationOutline EvaluationOutline { get; set; }

        public CheckListContainer CheckList { get; set; }

        public SeatContainer Seats_Q { get; set; }

        //TODO: Add Derived qualifications

        public void AddResourceRequirement(ResourceRequirement requirement)
        {
            //TODO: Move to Application layer. Interactors, etc.
            //Expected signature: Validate(EntityType, feature). Throws NotSupportedException
            //featureFlagSettings.Validate(this.GetType(), nameof(ResourceRequirements));
        }
    }
}