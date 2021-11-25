﻿using System;
using System.Collections.Generic;
using Bks.Fox.Domain.Notifications.Changes;

namespace Bks.Fox.Behaviors.Domain
{
    public interface IBehaviorContainer<T> : ICollection<T>
        where T : IBehaviorItem
    {
        event EventHandler<ChangeEventArgs> Changed;
    }
}