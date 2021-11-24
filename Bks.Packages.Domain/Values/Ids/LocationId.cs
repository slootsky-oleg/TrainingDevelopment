using System;

namespace Bks.Domain.Values.Ids
{
    public class LocationId : GuidValueObject
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}