using System;
using System.Collections.Generic;
using System.Linq;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.Packages.Domain.Entities;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Domain.Entities.Notifications.Audit;
using Bks.Packages.Domain.Values;

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
        private readonly ResourceRequirementContainer<TResourceRequirement> resourceRequirements;

        //TODO: better name
        public AggregationStrategy AggregationStrategy { get; }
        public IReadOnlyCollection<TResourceRequirement> ResourceRequirements => resourceRequirements.ToList();


        protected TrainingEntity(AuditRecord audit, Name name)
            : base(audit, name)
        {
            this.resourceRequirements = new ResourceRequirementContainer<TResourceRequirement>(null);
            this.resourceRequirements.Changed += BehaviorChangeHandler;
        }

        protected virtual void BehaviorChangeHandler(object sender, AuditEventArgs @event)
        {
            ValidateCanBeModified();

            var audit = @event.ToAuditRecord();
            AuditModification(audit);
        }
        
        public void Archive()
        {
            throw new System.NotImplementedException();
        }

        public void AddResourceRequirement(AuditRecord audit, TResourceRequirement requirement)
        {
            //Validate has requirements
            ValidateAndAudit(audit, () => resourceRequirements.Add(requirement));
        }

        public void RemoveResourceRequirement(AuditRecord audit, TResourceRequirement requirement)
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

        // private void ValidateCanOwnAggregatableBehaviors()
        // {
        //     if (AggregationStrategy == AggregationStrategy.BottomUp)
        //     {
        //         throw new NotSupportedException("");
        //     }
        // }
    }
}