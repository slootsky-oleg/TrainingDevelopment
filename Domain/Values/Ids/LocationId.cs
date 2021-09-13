using System;
using System.Collections.Generic;

namespace Domain.Values.Ids
{
    public class LocationId : GuidId
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}