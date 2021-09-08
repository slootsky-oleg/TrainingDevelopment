using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Activities;

namespace Domain.Entities.TrainingDevelopment.Plans
{
    public class TrainingPlan : TrainingDevelopmentCollectionEntity<TrainingDevelopmentEntity>
    {
        public TimeSpan Duration { get; set; }

        //TODO: Define objectives
        public ObjectivesEnvelop ObjectivesEnvelop { get; set; }
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
    }
}