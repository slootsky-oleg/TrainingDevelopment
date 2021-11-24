using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain.Settings.Alternatives;

namespace Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain.Settings
{
    public interface IResourceRequirementSettings : IBehaviorContainerSettings
    {
        IResourceRequirementAlternativeSettings AlternativeSettings { get; }
    }

    public interface IBehaviorContainerSettings
    {
        bool IsEnabled { get; }
    }
}