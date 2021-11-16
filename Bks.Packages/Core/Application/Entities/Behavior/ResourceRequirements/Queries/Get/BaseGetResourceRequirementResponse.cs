using System;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Packages.Core.Application.Entities.Behavior.ResourceRequirements.Queries.Get
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