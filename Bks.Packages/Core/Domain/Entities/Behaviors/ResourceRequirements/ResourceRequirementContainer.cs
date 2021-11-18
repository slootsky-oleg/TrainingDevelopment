using Bks.Packages.Core.Domain.Entities.Behaviors.Abstractions;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements.Settings;

namespace Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements
{
    public class ResourceRequirementContainer<T> : BehaviourContainer<T, IResourceRequirementSettings>
        where T : ResourceRequirement
    {
    }
}