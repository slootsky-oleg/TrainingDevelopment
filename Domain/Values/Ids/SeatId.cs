using System;
using System.Collections.Generic;

namespace Domain.Values.Ids
{
    public class SeatId : GuidId
    {
        public SeatId(Guid guid) : base(guid)
        {
        }
    }
}