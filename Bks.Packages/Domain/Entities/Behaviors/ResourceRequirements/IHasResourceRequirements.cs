using System.Collections.Generic;
using Bks.Packages.Domain.Values;

namespace Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements
{
    public interface IHasResourceRequirements<T>
        where T : ResourceRequirement
    {
        //IResourceRequirementContainer<TRequirement> ResourceRequirements { get; }

        public IReadOnlyCollection<T> ResourceRequirements { get; }
        void AddResourceRequirement(AuditRecord audit, T requirement);
        void RemoveResourceRequirement(AuditRecord audit, T requirement);
    }
}