using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements.Settings.Alternatives;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements.Settings
{
    public interface IResourceRequirementSettings
    {
        IResourceRequirementAlternativeSettings AlternativeSettings { get; }
    }
}