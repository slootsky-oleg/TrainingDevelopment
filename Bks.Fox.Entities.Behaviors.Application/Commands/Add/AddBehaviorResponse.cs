using System;
using Bks.Fox.Domain.Behaviors;

namespace Bks.Fox.Application.Behaviors.Commands.Add
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