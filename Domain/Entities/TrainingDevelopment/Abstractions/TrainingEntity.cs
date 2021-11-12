using System;
using System.Collections.Generic;
using System.Linq;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions.Settings;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.Packages.Core.Domain.Entities;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Core.Domain.Entities.Notifications.Changes;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions
{
    public abstract class TrainingEntity<TSettings, TResourceRequirement> : 
        AggregateRoot,
        ITrainingEntity<TResourceRequirement>

        where TResourceRequirement : ResourceRequirement
        where TSettings : ITrainingDevelopmentEntitySettings
        
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

        protected TSettings Settings;
        
        protected readonly ResourceRequirementContainer<TResourceRequirement> ResourceRequirementContainer;

        //TODO: better name
        public AggregationStrategy AggregationStrategy { get; }
        public IReadOnlyCollection<TResourceRequirement> ResourceRequirements => ResourceRequirementContainer.ToList();

        //TODO: Add settings, custom field schema
        protected TrainingEntity(
            UserFootprint footprint,
            Name name,
            TypeId typeId,
            TSettings settings)
            : base(footprint, name)
        {
            TypeId = typeId;
            Settings = settings;

            this.ResourceRequirementContainer = new ResourceRequirementContainer<TResourceRequirement>(settings.ResourceRequirement);
            SubscribeToChanges(ResourceRequirementContainer);
        }

        public void Archive()
        {
            throw new System.NotImplementedException();
        }

        public void SetType(
            UserFootprint footprint,
            TypeId typeId,
            TSettings settings
            //CustomFieldSchema
            )
        {
            if (typeId == null) throw new ArgumentNullException(nameof(typeId));
            if (settings == null) throw new ArgumentNullException(nameof(settings));


            ValidateAndAudit(footprint, () =>
            {
                TypeId = typeId;
                Settings = settings;
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