using System;

namespace Bks.Practices.Ddd.Domain.Values.Ids
{
    public class SeatId : GuidValueObject
    {
        public SeatId(Guid guid) : base(guid)
        {
        }
    }
}