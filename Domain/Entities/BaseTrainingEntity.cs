using System;
using System.Collections.Generic;
using System.Linq;
using Bks.Fox.Behaviors.Domain;
using Bks.Fox.Behaviors.ResourceRequirements.Domain;
using Bks.Fox.Domain.Entities;
using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities
{
    public abstract class BaseTrainingEntity<TResourceRequirement> : 
            AggregateRoot,
            IHasResourceRequirements<TResourceRequirement>
        
        //IHasRelatedEntities<TrainingTask>
        // IHasCustomFields, 
        // IHasContent, 
        // IVersionable,
        // IHasEvaluationCriteria,
        // IHasPrerequisites,
        // IHasConditions,
        // IHasTargetAudience,
        // IHasStatus
        where TResourceRequirement: ResourceRequirement
    {
        protected readonly ResourceRequirementContainer<TResourceRequirement> ResourceRequirementContainer;

        //TODO: Is versionable?
        public TypeId TypeId { get; private set; }

        //TODO: Init from ctor if mandatory
        public LibraryId LibraryId { get; private set; }

        //TODO: better name
        public AggregationStrategy AggregationStrategy { get; }
        public IReadOnlyCollection<TResourceRequirement> ResourceRequirements => ResourceRequirementContainer.ToList();

        protected BaseTrainingEntity(
            UserFootprint footprint,
            Name name,
            TypeId typeId)
            : base(footprint, name)
        {
            TypeId = typeId;

            this.ResourceRequirementContainer = new ResourceRequirementContainer<TResourceRequirement>();
            SubscribeToChanges(ResourceRequirementContainer);
        }

        public void Archive()
        {
            throw new System.NotImplementedException();
        }

        public void SetType(
            UserFootprint footprint,
            TypeId typeId
            //CustomFieldSchema
        )
        {
            if (typeId == null) throw new ArgumentNullException(nameof(typeId));

            //New settings might affect existing values: resource requirements aren't allowed for the new type
            //New settings might affect custom fields: new schema doesn't contain a field


            ValidateAndAudit(footprint, () =>
            {
                TypeId = typeId;
            });
        }

        public void AddResourceRequirement(UserFootprint footprint, TResourceRequirement requirement)
        {
            //Validate has requirements
            ValidateAndAudit(footprint, () => ResourceRequirementContainer.Add(requirement));
        }

        public void RemoveResourceRequirement(UserFootprint footprint, TResourceRequirement requirement)
        {
            ValidateAndAudit(footprint, () => ResourceRequirementContainer.Remove(requirement));
        }

        private void ValidateAndAudit(UserFootprint footprint, Action action)
        {
            ValidateCanBeModified();
            AuditModification(footprint);

            action.Invoke();
        }

        private T ValidateAndAudit<T>(UserFootprint footprint, Func<T> action)
        {
            ValidateCanBeModified();
            AuditModification(footprint);

            return action.Invoke();
        }

        private void SubscribeToChanges(INotifyEntityChanged source)
        {
            source.Changed += BehaviorChangeHandler;
        }

        private void BehaviorChangeHandler(object sender, ChangeEventArgs @event)
        {
            ValidateCanBeModified();

            var footprint = @event.ToUserFootprint();
            AuditModification(footprint);
        }

        // private void ValidateCanOwnAggregatableBehaviors()
        // {
        //     if (AggregationStrategy == AggregationStrategy.BottomUp)
        //     {
        //         throw new NotSupportedException("");
        //     }
        // }
    }
}