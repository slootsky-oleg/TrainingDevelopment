// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Activities;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;
//
// namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Plans
// {
//     public class Plan :
//         TrainingEntity<ResourceRequirement>,
//         ITrainingCollection<TrainingTask>
//     {
//         public TimeSpan Duration { get; private set; }
//
//         public IReadOnlyCollection<PlannedTraining<Plan>> Plans { get; }
//         public IReadOnlyCollection<PlannedTraining<Activity>> Activities { get; }
//
//
//         public void Archive()
//         {
//             throw new NotImplementedException();
//         }
//
//         public IReadOnlyCollection<TrainingTask> GetTrainingItems()
//         {
//             var plans = Plans
//                 .Select(p => p.Training.GetTrainingItems())
//                 .SelectMany(p => p);
//
//             var activities = Activities
//                 .Select(a => a.Training.GetTrainingItems())
//                 .SelectMany(a => a);
//
//             return plans
//                 .Concat(activities)
//                 .ToList();
//         }
//     }
// }