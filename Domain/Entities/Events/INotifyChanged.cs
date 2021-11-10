using System;
using Bks.TrainingDevelopment.Domain.Values;

namespace Bks.TrainingDevelopment.Domain.Entities.Events
{
    public interface INotifyChanged
    {
        event EventHandler<AuditEventArgs> Changed;
    }
}