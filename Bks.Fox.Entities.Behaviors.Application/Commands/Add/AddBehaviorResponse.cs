using System;
using Bks.Fox.Entities.Behaviors.Domain;

namespace Bks.Fox.Entities.Behaviors.Application.Commands.Add
{
    public abstract class AddBehaviorResponse
    {
        public Guid Id { get; }

        protected AddBehaviorResponse(IBehaviorItem behaviour)
        {
            Id = behaviour.Id;
        }
    }
}