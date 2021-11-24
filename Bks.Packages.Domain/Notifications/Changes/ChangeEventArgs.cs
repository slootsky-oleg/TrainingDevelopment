using System;
using Bks.Domain.Values;
using Bks.Domain.Values.Ids;

namespace Bks.Domain.Notifications.Changes
{
    public class ChangeEventArgs : EventArgs
    {
        public UserId UserId { get; }
        public DateTime Timestamp { get; }

        public ChangeEventArgs(UserId userId, DateTime timestamp)
        {
            UserId = userId;
            Timestamp = timestamp;
        }

        public ChangeEventArgs(UserFootprint footprint)
        {
            if (footprint == null) throw new ArgumentNullException(nameof(footprint));

            UserId = footprint.UserId;
            Timestamp = footprint.Timestamp;
        }

        public UserFootprint ToUserFootprint()
        {
            return new UserFootprint(UserId, Timestamp);
        }
    }
}