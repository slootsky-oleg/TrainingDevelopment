// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Collections;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;
//
// namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Activities
// {
//     public class Activity :
//         TrainingEntity<ResourceRequirement>,
//         ITrainingCollection<TrainingTask>
//     {
//         public TimeSpan Duration { get; set; }
//         public IReadOnlyCollection<TrainingTask> Tasks { get; }
//         public IReadOnlyCollection<TaskCollection> TaskCollections { get; }
//
//         public void Archive()
//         {
//             throw new NotImplementedException();
//         }
//
//         public IReadOnlyCollection<TrainingTask> GetTrainingItems()
//         {
//             var tasksFromCollections = TaskCollections
//                 .Select(s => s.GetTrainingItems())
//                 .SelectMany(s => s);
//
//             return tasksFromCollections
//                 .Concat(Tasks)
//                 .ToList();
//         }
//     }
// }