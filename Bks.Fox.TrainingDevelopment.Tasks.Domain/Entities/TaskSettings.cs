using Bks.Fox.Behaviors.ResourceRequirements.Domain.Settings;
using Bks.Fox.TrainingDevelopment.Domain.TODO.Settings;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TaskSettings : ITrainingDevelopmentEntitySettings
    {
        public IResourceRequirementSettings ResourceRequirement { get; }
    }
}