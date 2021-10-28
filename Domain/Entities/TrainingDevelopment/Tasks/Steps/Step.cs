using System.Collections.Generic;
using System.Linq;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks.Steps
{
    public class Step : 
        TrainingEntity,
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
        //TODO: Conditions: weather, etc

        public IReadOnlyCollection<Step> Steps_Q { get; }

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