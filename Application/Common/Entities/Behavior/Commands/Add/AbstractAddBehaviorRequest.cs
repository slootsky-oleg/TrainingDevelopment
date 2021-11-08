using System;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Behavior.Commands.Add
{
    public abstract class AbstractAddBehaviorRequest
    {
        public Guid EntityId { get; set; }
    }
}