using System;

namespace Bks.Packages.Core.Application.Entities.Behavior.ResourceRequirements.Commands.Add
{
    public abstract class BaseAddResourceRequirementRequest
    {
        public Guid TypeId { get; set; }

        //TODO: quantity value
        public int? Quantity { get; set; }
    }
}