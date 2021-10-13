using System;

namespace Domain.Values.Ids
{
    public class LocationId : GuidId
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}