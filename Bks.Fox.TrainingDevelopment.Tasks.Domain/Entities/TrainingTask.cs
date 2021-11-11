using System;
using System.Collections.Generic;
using System.Linq;
using Bks.Packages.Domain.Entities;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Domain.Entities.Notifications.Audit;
using Bks.Packages.Domain.Values;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TrainingTask : 
        AggregateRoot,
        ITrainingEntity<ResourceRequirement>
        
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
        private readonly ResourceRequirementContainer<ResourceRequirement> resourceRequirements;

        public TrainingTask(Name name) : base(name)
        {
            this.resourceRequirements = new ResourceRequirementContainer<ResourceRequirement>(null);
            this.resourceRequirements.Changed += BehaviorChangeHandler;
        }

        private void BehaviorChangeHandler(object sender, AuditEventArgs @event)
        {
            ValidateCanBeModified();

            var audit = new AuditRecord(@event.UserId, @event.Timestamp);
            AuditModification(audit);
        }

        //TODO: better name
        public AggregationStrategy AggregationStrategy { get; }

        private bool CanStoreBehaviors => AggregationStrategy != AggregationStrategy.BottomUp;
        
        public void Archive()
        {
            throw new System.NotImplementedException();
        }

        public IReadOnlyCollection<ResourceRequirement> ResourceRequirements => resourceRequirements.ToList();
        
        public void Add(AuditRecord audit, ResourceRequirement requirement)
        {
            ValidateCanOwnAggregatableBehaviors();
            ValidateAndAudit(audit, () => resourceRequirements.Add(requirement));
        }

        public void Remove(AuditRecord audit, ResourceRequirement requirement)
        {
            ValidateAndAudit(audit, () => resourceRequirements.Remove(requirement));
        }

        private void ValidateAndAudit(AuditRecord audit, Action action)
        {
            ValidateCanBeModified();
            AuditModification(audit);

            action.Invoke();
        }

        private T ValidateAndAudit<T>(AuditRecord audit, Func<T> action)
        {
            ValidateCanBeModified();
            AuditModification(audit);

            return action.Invoke();
        }

        private void ValidateCanOwnAggregatableBehaviors()
        {
            if (AggregationStrategy == AggregationStrategy.BottomUp)
            {
                throw new NotSupportedException("");
            }
        }

        public override void ValidateCanBeModified()
        {
            throw new NotImplementedException();
        }

        public override void AuditModification(AuditRecord audit)
        {
            throw new NotImplementedException();
        }
    }
}