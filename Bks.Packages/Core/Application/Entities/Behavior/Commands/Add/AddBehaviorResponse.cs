using System;
using Bks.Packages.Core.Domain.Entities.Behaviors.Abstractions;

namespace Bks.Packages.Core.Application.Entities.Behavior.Commands.Add
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