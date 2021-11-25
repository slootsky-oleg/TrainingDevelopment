using System;
using Bks.Fox.Behaviors.Domain;

namespace Bks.Fox.Behaviors.Application.Commands.Add
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