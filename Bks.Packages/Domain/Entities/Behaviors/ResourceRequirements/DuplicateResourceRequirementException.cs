using System;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements
{
    public class DuplicateResourceRequirementException : Exception
    {
        public GuidId ResourceTypeId { get; }

        public DuplicateResourceRequirementException(ResourceRequirement item)
            : base($"...")
        {
            ResourceTypeId = item.ResourceTypeId;
        }
    }
}