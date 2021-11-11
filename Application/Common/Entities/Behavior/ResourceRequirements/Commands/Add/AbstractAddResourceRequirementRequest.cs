using System;
using Bks.TrainingDevelopment.Application.Common.Entities.Behavior.Commands.Add;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Behavior.ResourceRequirements.Commands.Add
{
    public abstract class AbstractAddResourceRequirementRequest
    {
        public Guid TypeId { get; set; }

        //TODO: quantity value
        public int? Quantity { get; set; }
    }
}