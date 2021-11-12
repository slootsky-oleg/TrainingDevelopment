using System;
using System.Collections.Generic;
using Bks.Packages.Domain.Entities.Notifications.Changes;

namespace Bks.Packages.Domain.Entities.Behaviors.Abstractions
{
    public interface IBehaviorContainer<T> : ICollection<T>
        where T : IBehaviorItem
    {
        event EventHandler<ChangeEventArgs> Changed;
    }
}