using System;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Packages.Application.Entities.Behavior.ResourceRequirements.Queries.Get
{
    public abstract class AbstractGetResourceRequirementResponse
    {
        public Guid Id { get; }
        public Guid TypeId { get; }
        public int? Quantity { get; }

        protected AbstractGetResourceRequirementResponse(ResourceRequirement requirement)
        {
            Id = requirement.Id;
            TypeId = requirement.ResourceTypeId;
            Quantity = requirement.Quantity;
        }
    }
}