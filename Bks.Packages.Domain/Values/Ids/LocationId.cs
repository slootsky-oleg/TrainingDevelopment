using System;

namespace Bks.Packages.Domain.Values.Ids
{
    public class LocationId : GuidValueObject
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}