﻿using System;
using System.Collections.Generic;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Values
{
    public class AuditRecord : ValueObject
    {
        public int UserId { get; }
        public DateTime Timestamp { get; }

        public AuditRecord(int userId, DateTime timestamp)
        {
            UserId = userId;
            Timestamp = timestamp;
        }

        public AuditRecord(int userId)
            : this(userId, DateTime.Now)
        {
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return UserId;
            yield return Timestamp;
        }
    }
}