using System;
using System.Collections.Generic;
using Bks.Domain.Notifications.Changes;

namespace Bks.Fox.Entities.Behaviors.Domain
{
    public interface IBehaviorContainer<T> : ICollection<T>
        where T : IBehaviorItem
    {
        event EventHandler<ChangeEventArgs> Changed;
    }
}