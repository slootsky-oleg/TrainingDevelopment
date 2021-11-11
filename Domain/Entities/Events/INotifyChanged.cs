using System;

namespace Bks.TrainingDevelopment.Domain.Entities.Events
{
    public interface INotifyChanged
    {
        event EventHandler<AuditEventArgs> Changed;
    }
}