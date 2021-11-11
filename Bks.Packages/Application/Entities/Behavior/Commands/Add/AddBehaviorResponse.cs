using System;
using Bks.Packages.Domain.Entities.Behaviors;
using Bks.Packages.Domain.Entities.Behaviors.Abstractions;

namespace Bks.Packages.Application.Entities.Behavior.Commands.Add
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