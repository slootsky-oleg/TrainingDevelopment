using System;
using System.Collections.Generic;
using System.Linq;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.Packages.Domain.Entities;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Domain.Entities.Notifications.Changes;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment
{
    public abstract class TrainingEntity<TResourceRequirement> : 
        AggregateRoot,
        ITrainingEntity<TResourceRequirement>

        where TResourceRequirement : ResourceRequirement
        
    //IHasRelatedEntities<TrainingTask>
    // IHasCustomFields, 
    // IHasContent, 
    // IVersionable,
    // IHasEvaluationCriteria,
    // IHasPrerequisites,
    // IHasConditions,
    // IHasTargetAudience,
    // IHasStatus
    {
        //TODO: Is versionable?
        public TypeId TypeId { get; private set; }
        
        protected readonly ResourceRequirementContainer<TResourceRequirement> resourceRequirements;

        //TODO: better name
        public AggregationStrategy AggregationStrategy { get; }
        public IReadOnlyCollection<TResourceRequirement> ResourceRequirements => resourceRequirements.ToList();


        protected TrainingEntity(UserFootprint footprint, Name name)
            : base(footprint, name)
        {
            //TODO: how to inject settings?
            this.resourceRequirements = new ResourceRequirementContainer<TResourceRequirement>(settings: null);
            SubscribeToChanges(resourceRequirements);
        }

        public void Archive()
        {
            throw new System.NotImplementedException();
        }

        public void SetTypeId(UserFootprint footprint, TypeId typeId)
        {
            ValidateAndAudit(footprint, () => TypeId = typeId);
        }

        public void AddResourceRequirement(UserFootprint footprint, TResourceRequirement requirement)
        {
            //Validate has requirements
            ValidateAndAudit(footprint, () => resourceRequirements.Add(requirement));
        }

        public void RemoveResourceRequirement(UserFootprint footprint, TResourceRequirement requirement)
        {
            ValidateAndAudit(footprint, () => resourceRequirements.Remove(requirement));
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