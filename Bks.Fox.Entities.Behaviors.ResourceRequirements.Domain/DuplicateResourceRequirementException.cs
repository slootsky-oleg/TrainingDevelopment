using System;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Domain.Behaviors.ResourceRequirements
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