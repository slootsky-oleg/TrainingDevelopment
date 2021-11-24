// using System.Collections.Generic;
// using System.Linq;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
//
// namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Collections
// {
//     public class TaskCollection :
//         Entity,
//         ITrainingEntity<ResourceRequirement>,
//         ITrainingCollection<TrainingTask>
//     {
//         public IReadOnlyCollection<TrainingTask> Tasks { get; }
//         public IReadOnlyCollection<TaskCollection> TaskCollections { get; }
//
//         public IResourceRequirementContainer<ResourceRequirement> ResourceRequirements { get; }
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
//
//         public void Archive()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
// }