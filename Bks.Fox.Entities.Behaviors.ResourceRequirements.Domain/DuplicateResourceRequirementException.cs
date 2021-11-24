using System;
using Bks.Domain.Values.Ids;

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