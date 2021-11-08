using System;
using System.Collections.Generic;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Values
{
    public class AuditRecord : ValueObject
    {
        public GuidId UserId { get; }
        public DateTime Timestamp { get; }

        public AuditRecord(GuidId userId, DateTime timestamp)
        {
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            Timestamp = timestamp;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return UserId;
            yield return Timestamp;
        }
    }
}