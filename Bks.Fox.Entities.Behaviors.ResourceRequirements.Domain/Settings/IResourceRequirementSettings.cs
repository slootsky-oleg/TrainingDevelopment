using Bks.Fox.Domain.Behaviors.ResourceRequirements.Settings.Alternatives;

namespace Bks.Fox.Domain.Behaviors.ResourceRequirements.Settings
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