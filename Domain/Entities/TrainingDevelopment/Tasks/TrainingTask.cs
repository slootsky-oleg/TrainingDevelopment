using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks
{
    public class TrainingTask : 
        Entity,
        IHasResourceRequirements<ResourceRequirement>
        
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
        public IResourceRequirementContainer<ResourceRequirement> ResourceRequirements { get; }
        
        public void Archive()
        {
            throw new System.NotImplementedException();
        }
    }
}