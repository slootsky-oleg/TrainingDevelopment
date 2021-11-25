using System.Collections.Generic;
using Bks.Fox.Domain.Values;

namespace Bks.Fox.Behaviors.ResourceRequirements.Domain
{
    public interface IHasResourceRequirements<T>
        where T : ResourceRequirement
    {
        public IReadOnlyCollection<T> ResourceRequirements { get; }
        void AddResourceRequirement(UserFootprint footprint, T requirement);
        void RemoveResourceRequirement(UserFootprint footprint, T requirement);
    }
}