using System;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Behavior.Commands.Add
{
    public class AbstractAddBehaviorResponse
    {
        public Guid Id { get; }

        protected AbstractAddBehaviorResponse(IBehaviorItem behaviour)
        {
            Id = behaviour.Id;
        }
    }
}