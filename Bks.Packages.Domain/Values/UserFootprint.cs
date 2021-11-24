using System;
using System.Collections.Generic;
using Bks.Fox.Entities.Domain.Values.Ids;

namespace Bks.Fox.Entities.Domain.Values
{
    public class UserFootprint : ValueObject
    {
        public UserId UserId { get; }
        public DateTime Timestamp { get; }

        public UserFootprint(UserId userId, DateTime timestamp)
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