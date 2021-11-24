using System;
using Bks.Fox.Domain.Behaviors.ResourceRequirements;

namespace Bks.Fox.Application.Behaviors.ResourceRequirements.Queries.Common
{
    public class GetResourceRequirementResponse
    {
        public Guid Id { get; }
        public Guid TypeId { get; }
        public int? Quantity { get; }

        public GetResourceRequirementResponse(ResourceRequirement requirement)
        {
            Id = requirement.Id;
            TypeId = requirement.ResourceTypeId;
            Quantity = requirement.Quantity;
        }
    }
}