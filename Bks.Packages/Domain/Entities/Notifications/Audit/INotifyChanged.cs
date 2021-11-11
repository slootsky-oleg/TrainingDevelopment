using System;

namespace Bks.Packages.Domain.Entities.Notifications.Audit
{
    public interface INotifyChanged
    {
        event EventHandler<AuditEventArgs> Changed;
    }
}