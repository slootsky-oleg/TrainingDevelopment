using System;
using Bks.Packages.Domain.Values;

namespace Bks.TrainingDevelopment.Domain.Entities.Events
{
    public class AuditEventArgs : EventArgs
    {
        public int UserId { get; }
        public DateTime Timestamp { get; }

        public AuditEventArgs(int userId, DateTime timestamp)
        {
            UserId = userId;
            Timestamp = timestamp;
        }

        public AuditEventArgs(AuditRecord audit)
        {
            if (audit == null) throw new ArgumentNullException(nameof(audit));

            UserId = audit.UserId;
            Timestamp = audit.Timestamp;
        }
    }
}