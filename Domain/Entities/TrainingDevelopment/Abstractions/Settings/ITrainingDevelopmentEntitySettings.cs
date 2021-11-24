
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain.Settings;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions.Settings
{
    public interface ITrainingDevelopmentEntitySettings
    {
        IResourceRequirementSettings ResourceRequirement { get; }
    }
}