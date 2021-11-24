
using Bks.Fox.Domain.Behaviors.ResourceRequirements.Settings;

namespace Bks.Fox.Domain.TrainingDevelopment.TODO.Settings
{
    public interface ITrainingDevelopmentEntitySettings
    {
        IResourceRequirementSettings ResourceRequirement { get; }
    }
}