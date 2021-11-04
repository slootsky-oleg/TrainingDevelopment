namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities
{
    public class RelatedEntityContainer<T> : IHasRelatedEntities<T>
        where T : ITrainingEntity
    {
        public RelatedEntityContainer<T> RelatedEntities { get; }
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
    //     public EntityTypeId TypeId { get; }
    //
    //     //Does it belong to the base entity?
    //     public PrerequisiteContainer Prerequisites { get; set; }
    //
    //     //Does it belong to the base entity?
    //     public ResourceRequirementsContainer ResourceRequirements { get; set; }
    //
    //     public CustomFieldContainer CustomFields { get; set; }
    //
    //     public ContentContainer Content { get; set; }
    //
    //     #region availability
    //
    //     //Sounds like state machine that can be handled with only two methods  - push down / up
    //     //Active-Deprecated-Obsolete-Archived
    //     public virtual void Activate()
    //     {
    //     }
    //
    //     public virtual void Deprecate()
    //     {
    //     }
    //
    //     public virtual void Obsolete()
    //     {
    //     }
    //     
    //     public virtual void Archive()
    //     {
    //     }
    //     #endregion
    //
    //     // //Restore to a specific step or always to a previous. Consider using dedicated methods
    //     // public virtual void Restore()
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
    //     public SeatContainer Seats { get; set; }
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