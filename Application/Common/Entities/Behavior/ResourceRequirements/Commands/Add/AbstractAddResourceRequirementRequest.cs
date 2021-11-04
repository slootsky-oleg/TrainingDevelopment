using System;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Behavior.ResourceRequirements.Commands.Add
{
    public class AbstractAddResourceRequirementRequest
    {
        public Guid TypeId { get; set; }
        public int? Quantity { get; set; }
    }
}