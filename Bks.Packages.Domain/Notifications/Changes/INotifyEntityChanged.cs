using System;

namespace Bks.Fox.Domain.Notifications.Changes
{
    public interface INotifyEntityChanged
    {
        event EventHandler<ChangeEventArgs> Changed;
    }
}