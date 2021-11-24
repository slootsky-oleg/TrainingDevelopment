using Bks.Packages.Domain.Entities.Behaviors.Abstractions;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings;

namespace Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements
{
    public class ResourceRequirementContainer<T> : BehaviourContainer<T, IResourceRequirementSettings>
        where T : ResourceRequirement
    {
    }
}