using System.Collections.Generic;
using Bks.Packages.Core.Domain.Values;

namespace Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements
{
    public interface IHasResourceRequirements<T>
        where T : ResourceRequirement
    {
        public IReadOnlyCollection<T> ResourceRequirements { get; }
        void AddResourceRequirement(UserFootprint footprint, T requirement);
        void RemoveResourceRequirement(UserFootprint footprint, T requirement);
    }
}