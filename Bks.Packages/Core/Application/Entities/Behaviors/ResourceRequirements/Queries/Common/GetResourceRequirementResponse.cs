using System;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Queries.Common
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