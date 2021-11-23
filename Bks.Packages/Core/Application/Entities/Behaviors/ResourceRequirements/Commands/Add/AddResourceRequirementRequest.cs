using System;

namespace Bks.Packages.Core.Application.Entities.Behaviors.ResourceRequirements.Commands.Add
{
    public class AddResourceRequirementRequest
    {
        public Guid TypeId { get; set; }

        //TODO: quantity value
        public int? Quantity { get; set; }
    }
}