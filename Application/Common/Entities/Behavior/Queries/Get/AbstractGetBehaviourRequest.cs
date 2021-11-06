using System;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Behavior.Queries.Get
{
    public abstract class AbstractGetBehaviourRequest
    {
        public Guid EntityId { get; set; }
        public Guid BehaviorId { get; set; }
    }
}