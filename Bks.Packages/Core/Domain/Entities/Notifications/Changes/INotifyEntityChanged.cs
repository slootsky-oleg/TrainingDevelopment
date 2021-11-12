using System;

namespace Bks.Packages.Core.Domain.Entities.Notifications.Changes
{
    public interface INotifyEntityChanged
    {
        event EventHandler<ChangeEventArgs> Changed;
    }
}