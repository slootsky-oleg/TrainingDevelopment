using System;

namespace Bks.Domain.Notifications.Changes
{
    public interface INotifyEntityChanged
    {
        event EventHandler<ChangeEventArgs> Changed;
    }
}