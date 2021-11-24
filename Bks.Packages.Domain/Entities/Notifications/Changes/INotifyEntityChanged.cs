using System;

namespace Bks.Packages.Domain.Entities.Notifications.Changes
{
    public interface INotifyEntityChanged
    {
        event EventHandler<ChangeEventArgs> Changed;
    }
}