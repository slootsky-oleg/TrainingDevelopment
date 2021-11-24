using System;

namespace Bks.Fox.Entities.Domain.Notifications.Changes
{
    public interface INotifyEntityChanged
    {
        event EventHandler<ChangeEventArgs> Changed;
    }
}