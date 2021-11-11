// using System.Collections.Generic;
// using System.Linq;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
// using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
//
// namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps
// {
//     public class Step :
//         TrainingEntity<ResourceRequirement>,
//         ITrainingCollection<Step>
//     {
//         //TODO: can be defined as a collection of leader/critical steps on the owner's level (task/step)
//         //This may simplify validations (only 5 leader steps)
//         //TODO: Conditions: weather, etc
//
//         public IReadOnlyCollection<Step> Steps { get; }
//
//
//         public IReadOnlyCollection<Step> GetTrainingItems()
//         {
//             //recursively get all steps. Handle duplicates is steps are sharable
//             return Steps
//                 .Select(s => s.GetTrainingItems())
//                 .SelectMany(s => s)
//                 .ToList();
//         }
//     }
// }