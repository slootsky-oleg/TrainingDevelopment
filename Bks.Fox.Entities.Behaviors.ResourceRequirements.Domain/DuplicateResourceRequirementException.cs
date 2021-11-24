using System;
using Bks.Practices.Ddd.Domain.Values.Ids;

namespace Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain
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