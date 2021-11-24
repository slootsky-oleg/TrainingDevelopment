using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions.Settings;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TaskSettings : ITrainingDevelopmentEntitySettings
    {
        public IResourceRequirementSettings ResourceRequirement { get; }
    }
}