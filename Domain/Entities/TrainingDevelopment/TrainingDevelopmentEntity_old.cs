using System.Collections.Generic;
using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Entities.TrainingDevelopment.Containers.Resources;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment
{
    public interface ITrainingDevelopmentEntity
    {
        GuidId Id { get; set; }
        ExternalId ExternalId { get; set; }
        Description Description { get; set; }
        Name Name { get; set; }
    }

    public interface IHasPrerequisites
    {
        PrerequisiteContainer Prerequisites_Q { get; }
    }

    public interface IHasResourceRequirements
    {
        ResourceRequirementsContainer ResourceRequirements_Q { get; }
    }

    public interface IHasCustomFields
    {
        CustomFieldContainer CustomFields { get; }
    }

    public interface IHasContent
    {
        ContentContainer_Q Content_Q { get; }
    }

    public interface IHasTargetAudience
    {
        TargetAudienceContainer TargetAudience { get; }
    }

    public interface IHasSeats
    {
        SeatContainer Seats_Q { get; }
    }

    public interface IHasRelatedEntities<T> 
        where T: ITrainingDevelopmentEntity
    {
        public RelatedEntityContainer<T> RelatedEntities_Q { get; }
    }

    public class RelatedEntityContainer<T>: IHasRelatedEntities<T> 
        where T: ITrainingDevelopmentEntity
    {
        public RelatedEntityContainer<T> RelatedEntities_Q { get; }
    }

    public interface ITrainingCollection<T>
        where T: ITrainingDevelopmentEntity
    {
        public IReadOnlyCollection<T> GetTrainingItems_Q();
    }

    public interface IHasCheckList
    {
        CheckListContainer CheckList { get; }
    }

    public interface IEvaluable
    {
        EvaluationOutline EvaluationOutline_Q { get; }
    }

    public interface IArchivable
    {
        void Activate_Q();
        void Deprecate_Q();
        void Obsolete_Q();
        void Archive_Q();
    }

    // public abstract class TrainingDevelopmentEntity_old : ITrainingDevelopmentEntity,
    //     IHasPrerequisites,
    //     IHasResourceRequirements,
    //     IHasCustomFields,
    //     IHasContent,
    //     IHasTargetAudience,
    //     IHasSeats,
    //     IHasCheckList,
    //     IEvaluable,
    //     IArchivable
    // {
    //     public GuidId Id { get; set; }
    //     public ExternalId ExternalId { get; set; }
    //     public Description Description { get; set; }
    //     public Name Name { get; set; }
    //     
    //     //Consider uniting with custom fields (SetId inside the custom field container)
    //     public EntityTypeId TypeId_Q { get; }
    //
    //     //Does it belong to the base entity?
    //     public PrerequisiteContainer Prerequisites_Q { get; set; }
    //
    //     //Does it belong to the base entity?
    //     public ResourceRequirementsContainer ResourceRequirements_Q { get; set; }
    //
    //     public CustomFieldContainer CustomFields { get; set; }
    //
    //     public ContentContainer_Q Content { get; set; }
    //
    //     #region availability
    //
    //     //Sounds like state machine that can be handled with only two methods  - push down / up
    //     //Active-Deprecated-Obsolete-Archived
    //     public virtual void Activate_Q()
    //     {
    //     }
    //
    //     public virtual void Deprecate_Q()
    //     {
    //     }
    //
    //     public virtual void Obsolete_Q()
    //     {
    //     }
    //     
    //     public virtual void Archive_Q()
    //     {
    //     }
    //     #endregion
    //
    //     // //Restore to a specific step or always to a previous. Consider using dedicated methods
    //     // public virtual void Restore_Q()
    //     // {
    //     // }
    //
    //     //TODO: Versioning
    //
    //     public TargetAudienceContainer TargetAudience { get; set; }
    //
    //     public EvaluationOutline EvaluationOutline { get; set; }
    //
    //     public CheckListContainer CheckList { get; set; }
    //
    //     public SeatContainer Seats_Q { get; set; }
    //
    //     //TODO: Add Derived qualifications
    //
    //     public virtual void AddResourceRequirement(ResourceRequirement requirement)
    //     {
    //         //TODO: Move to Application layer. Interactors, etc.
    //         //Expected signature: Validate(EntityType, feature). Throws NotSupportedException
    //         //featureFlagSettings.Validate(this.GetType(), nameof(ResourceRequirements));
    //     }
    // }
}