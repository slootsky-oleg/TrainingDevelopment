using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Behaviour;
using Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;

namespace Domain.Entities.TrainingDevelopment.Tasks.Steps
{
    public class Step : 
        TrainingDevelopmentEntity,
        IEvaluable,
        IHasConditions,
        IHasPrerequisites,
        IHasResourceRequirements<ResourceRequirement>,
        IHasSeats,
        IHasTargetAudience,
        ITrainingCollection<Step>
    {
        //TODO: can be defined as a collection of leader/critical steps on the owner's level (task/step)
        //This may simplify validations (only 5 leader steps)
        public bool IsLeader_Q { get; set; }
        public bool IsCritical_Q { get; set; }
        //TODO: Conditions: weather, etc

        public IReadOnlyCollection<Step> Steps_Q { get; set; }

        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ResourceRequirementsContainer<ResourceRequirement> ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience_Q { get; }
        public ExecutionConditionContainer Conditions_Q { get; }


        public IReadOnlyCollection<Step> GetTrainingItems_Q()
        {
            //recursively get all steps. Handle duplicates is steps are sharable
            return Steps_Q
                .Select(s => s.GetTrainingItems_Q())
                .SelectMany(s => s)
                .ToList();
        }
    }
}