
using Bks.Fox.Behaviors.ResourceRequirements.Domain.Settings;

namespace Bks.Fox.TrainingDevelopment.Domain.TODO.Settings
{
    public interface ITrainingDevelopmentEntitySettings
    {
        IResourceRequirementSettings ResourceRequirement { get; }
    }
}