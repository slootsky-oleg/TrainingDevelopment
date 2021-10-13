using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Behaviours;
using Domain.Entities.TrainingDevelopment.Behaviours.Conditions;
using Domain.Entities.TrainingDevelopment.Behaviours.Evaluation;
using Domain.Entities.TrainingDevelopment.Behaviours.Prerequisities;
using Domain.Entities.TrainingDevelopment.Behaviours.RelatedEntities;
using Domain.Entities.TrainingDevelopment.Behaviours.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.Behaviours.Seats;
using Domain.Entities.TrainingDevelopment.Behaviours.TargetAudience;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    //Should we define Collective and Individual entities?
    public class Task_Q : 
        TrainingDevelopmentEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasConditions,
        IHasResourceRequirements,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        IHasRelatedEntities<Task_Q>
    {
        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ExecutionConditionContainer Conditions_Q { get; }
        public ResourceRequirementsContainer ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience_Q { get; }
        public RelatedEntityContainer<Task_Q> RelatedEntities_Q { get; }


        public void Activate_Q()
        {
            throw new System.NotImplementedException();
        }

        public void Deprecate_Q()
        {
            throw new System.NotImplementedException();
        }

        public void Obsolete_Q()
        {
            throw new System.NotImplementedException();
        }

        public void Archive_Q()
        {
            throw new System.NotImplementedException();
        }
    }
}