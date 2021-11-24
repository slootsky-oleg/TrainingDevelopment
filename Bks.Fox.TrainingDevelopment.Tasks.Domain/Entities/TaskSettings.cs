using Bks.Fox.Domain.Behaviors.ResourceRequirements.Settings;
using Bks.Fox.TrainingDevelopment.Domain.TODO.Settings;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TaskSettings : ITrainingDevelopmentEntitySettings
    {
        public IResourceRequirementSettings ResourceRequirement { get; }
    }
}