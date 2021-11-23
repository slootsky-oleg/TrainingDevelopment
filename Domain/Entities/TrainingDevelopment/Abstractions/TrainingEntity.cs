using System;
using System.Collections.Generic;
using System.Linq;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.Packages.Core.Domain.Entities;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Core.Domain.Entities.Notifications.Changes;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;
using Bks.Packages.TrainingDevelopment.Domain.Entities;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions
{
    public abstract class TrainingEntity : 
        AggregateRoot,
        ITrainingDevelopmentEntity
        
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
        protected readonly ResourceRequirementContainer<ResourceRequirement> ResourceRequirementContainer;

        //TODO: Is versionable?
        public TypeId TypeId { get; private set; }

        //TODO: Init from ctor if mandatory
        public LibraryId LibraryId { get; private set; }

        //TODO: better name
        public AggregationStrategy AggregationStrategy { get; }
        public IReadOnlyCollection<ResourceRequirement> ResourceRequirements => ResourceRequirementContainer.ToList();

        protected TrainingEntity(
            UserFootprint footprint,
            Name name,
            TypeId typeId)
            : base(footprint, name)
        {
            TypeId = typeId;

            this.ResourceRequirementContainer = new ResourceRequirementContainer<ResourceRequirement>();
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

        public void AddResourceRequirement(UserFootprint footprint, ResourceRequirement requirement)
        {
            //Validate has requirements
            ValidateAndAudit(footprint, () => ResourceRequirementContainer.Add(requirement));
        }

        public void RemoveResourceRequirement(UserFootprint footprint, ResourceRequirement requirement)
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