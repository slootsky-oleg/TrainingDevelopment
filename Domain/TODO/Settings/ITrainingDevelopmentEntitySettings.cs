
using Bks.Fox.Domain.Behaviors.ResourceRequirements.Settings;

namespace Bks.Fox.TrainingDevelopment.Domain.TODO.Settings
{
    public interface ITrainingDevelopmentEntitySettings
    {
        IResourceRequirementSettings ResourceRequirement { get; }
    }
}