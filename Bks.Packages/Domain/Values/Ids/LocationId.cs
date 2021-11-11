using System;

namespace Bks.Packages.Domain.Values.Ids
{
    public class LocationId : GuidId
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}