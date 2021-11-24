using System;

namespace Bks.Fox.Domain.Values.Ids
{
    public class LocationId : GuidValueObject
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}