using System;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Packages.Application.Entities.Behavior.ResourceRequirements.Queries.Get
{
    public abstract class BaseGetResourceRequirementResponse
    {
        public Guid Id { get; }
        public Guid TypeId { get; }
        public int? Quantity { get; }

        protected BaseGetResourceRequirementResponse(ResourceRequirement requirement)
        {
            Id = requirement.Id;
            TypeId = requirement.ResourceTypeId;
            Quantity = requirement.Quantity;
        }
    }
}