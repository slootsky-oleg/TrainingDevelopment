using Bks.Packages.Domain.Entities.Behaviors.Abstractions;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings.Alternatives;

namespace Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings
{
    public interface IResourceRequirementSettings : IBehaviorContainerSettings
    {
        IResourceRequirementAlternativeSettings AlternativeSettings { get; }
    }
}