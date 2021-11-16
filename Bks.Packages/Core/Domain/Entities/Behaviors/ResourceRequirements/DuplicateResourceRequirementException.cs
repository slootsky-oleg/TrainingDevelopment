using System;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements
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