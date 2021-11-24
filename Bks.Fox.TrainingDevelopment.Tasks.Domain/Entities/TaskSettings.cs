using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain.Settings;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions.Settings;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TaskSettings : ITrainingDevelopmentEntitySettings
    {
        public IResourceRequirementSettings ResourceRequirement { get; }
    }
}