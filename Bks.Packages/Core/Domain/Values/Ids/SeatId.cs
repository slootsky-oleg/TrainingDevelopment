using System;

namespace Bks.Packages.Core.Domain.Values.Ids
{
    public class SeatId : GuidValueObject
    {
        public SeatId(Guid guid) : base(guid)
        {
        }
    }
}