using Bks.Packages.Core.Domain.Entities.Behaviors.Abstractions;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements.Settings.Alternatives;

namespace Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements.Settings
{
    public interface IResourceRequirementSettings : IBehaviorContainerSettings
    {
        IResourceRequirementAlternativeSettings AlternativeSettings { get; }
    }
}