using System;
using Bks.TrainingDevelopment.Application.Common.Entities.Behavior.Commands.Add;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Behavior.ResourceRequirements.Commands.Add
{
    public abstract class AbstractAddResourceRequirementRequest : AbstractAddBehaviorRequest
    {
        public Guid TypeId { get; set; }
        public int? Quantity { get; set; }
    }
}