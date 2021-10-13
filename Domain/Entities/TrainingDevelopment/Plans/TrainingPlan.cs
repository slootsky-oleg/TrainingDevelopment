using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Activities;
using Domain.Entities.TrainingDevelopment.Behaviours;
using Domain.Entities.TrainingDevelopment.Behaviours.Evaluation;
using Domain.Entities.TrainingDevelopment.Behaviours.Prerequisities;
using Domain.Entities.TrainingDevelopment.Behaviours.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.Behaviours.Seats;
using Domain.Entities.TrainingDevelopment.Behaviours.TargetAudience;
using Domain.Entities.TrainingDevelopment.Tasks;

namespace Domain.Entities.TrainingDevelopment.Plans
{
    public class TrainingPlan : 
        TrainingDevelopmentEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasResourceRequirements,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        ITrainingCollection<Task_Q>
    {
        public TimeSpan Duration { get; set; }

        public ObjectivesContainer Objectives_Q { get; set; }
        public IReadOnlyCollection<PlannedTraining<TrainingPlan>> Plans_Q { get; set; }
        public IReadOnlyCollection<PlannedTraining<Activity>> Activities_Q { get; set; }

        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ResourceRequirementsContainer ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience_Q { get; }
        
        public void Activate_Q()
        {
            throw new NotImplementedException();
        }

        public void Deprecate_Q()
        {
            throw new NotImplementedException();
        }

        public void Obsolete_Q()
        {
            throw new NotImplementedException();
        }

        public void Archive_Q()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Task_Q> GetTrainingItems_Q()
        {
            var plans = Plans_Q
                .Select(p => p.Training.GetTrainingItems_Q())
                .SelectMany(p => p);

            var activities = Activities_Q
                .Select(a => a.Training.GetTrainingItems_Q())
                .SelectMany(a => a);

            return plans
                .Concat(activities)
                .ToList();
        }
    }
}