using System;

namespace Bks.Packages.Application.Entities.Behavior.ResourceRequirements.Commands.Add
{
    public abstract class AbstractAddResourceRequirementRequest
    {
        public Guid TypeId { get; set; }

        //TODO: quantity value
        public int? Quantity { get; set; }
    }
}