﻿using System;
using Bks.Packages.Domain.Entities.Behaviors;

namespace Bks.Packages.Application.Entities.Behavior.Commands.Add
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