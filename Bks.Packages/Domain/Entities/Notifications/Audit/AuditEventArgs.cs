using System;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Entities.Notifications.Audit
{
    public class AuditEventArgs : EventArgs
    {
        public UserId UserId { get; }
        public DateTime Timestamp { get; }

        public AuditEventArgs(UserId userId, DateTime timestamp)
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

        public AuditRecord ToAuditRecord()
        {
            return new AuditRecord(UserId, Timestamp);
        }
    }
}