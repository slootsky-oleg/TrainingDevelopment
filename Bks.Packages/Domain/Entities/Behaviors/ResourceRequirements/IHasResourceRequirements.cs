using System.Collections.Generic;
using Bks.Packages.Domain.Values;

namespace Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements
{
    public interface IHasResourceRequirements<T>
        where T : ResourceRequirement
    {
        //IResourceRequirementContainer<TRequirement> ResourceRequirements { get; }

        public IReadOnlyCollection<T> ResourceRequirements { get; }
        void Add(AuditRecord audit, T requirement);
        void Remove(AuditRecord audit, T requirement);
    }
}