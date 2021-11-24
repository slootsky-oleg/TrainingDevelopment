using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions.Settings
{
    public interface ITrainingDevelopmentEntitySettings
    {
        IResourceRequirementSettings ResourceRequirement { get; }
    }
}