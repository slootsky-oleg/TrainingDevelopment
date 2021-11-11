using System.Data;
using Bks.Packages.Domain.Entities.Behaviors.Abstractions;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings;

namespace Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements
{
    public class ResourceRequirementContainer<T> : BehaviourContainer<T>
        where T : ResourceRequirement
    {
        private readonly IResourceRequirementSettings settings;

        public ResourceRequirementContainer(IResourceRequirementSettings settings)
        {
            this.settings = settings;
        }

        public override void Add(T item)
        {
            if (settings.RequireUnique && Items.Contains(item))
            {
                throw new DuplicateResourceRequirementException(item);
            }

            base.Add(item);
        }
    }
}