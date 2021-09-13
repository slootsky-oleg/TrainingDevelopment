using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Activities;

namespace Domain.Entities.TrainingDevelopment.Plans
{
    public class TrainingPlan : TrainingDevelopmentCollectionEntity<TrainingDevelopmentEntity>
    {
        public TimeSpan Duration { get; set; }

        public ObjectivesContainer Objectives { get; set; }
        public IReadOnlyCollection<PlannedTraining<TrainingPlan>> Plans { get; set; }
        public IReadOnlyCollection<PlannedTraining<Activity>> Activities { get; set; }

        public override IReadOnlyCollection<TrainingDevelopmentEntity> GetTrainingItems()
        {
            var plans = Plans
                .Select(p => p.Training.GetTrainingItems())
                .SelectMany(p => p);

            var activities = Activities.Select(a => a.Training);

            return plans
                .Concat(activities)
                .ToList();
        }

        public override void Archive()
        {
            throw new NotImplementedException();
        }

        public override void Restore()
        {
            throw new NotImplementedException();
        }

    }
}