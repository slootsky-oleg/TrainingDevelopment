using System;
using System.Collections.Generic;
using Bks.Practices.Ddd.Domain.Values.Ids;

namespace Bks.Practices.Ddd.Domain.Values
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