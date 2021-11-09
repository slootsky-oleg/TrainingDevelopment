using System;
using System.Collections.Generic;
using System.Linq;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Bks.TrainingDevelopment.Domain.Values;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks
{
    public class TrainingTask : 
        Entity,
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
        private ResourceRequirementContainer<ResourceRequirement> resourceRequirements;

        //TODO: better name
        public AggregationStrategy AggregationStrategy { get; }

        private bool CanStoreBehaviors => AggregationStrategy != AggregationStrategy.BottomUp;
        
        public void Archive()
        {
            throw new System.NotImplementedException();
        }

        public IReadOnlyCollection<ResourceRequirement> ResourceRequirements => resourceRequirements.GetAll();
        
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
    }
}