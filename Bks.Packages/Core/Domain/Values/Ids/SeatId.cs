using System;

namespace Bks.Packages.Core.Domain.Values.Ids
{
    public class SeatId : GuidId
    {
        public SeatId(Guid guid) : base(guid)
        {
        }
    }
}