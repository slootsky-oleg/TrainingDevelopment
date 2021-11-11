using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings.Alternatives;

namespace Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings
{
    public interface IResourceRequirementSettings
    {
        IResourceRequirementAlternativeSettings AlternativeSettings { get; }
    }
}