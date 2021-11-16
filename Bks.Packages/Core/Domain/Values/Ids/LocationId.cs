using System;

namespace Bks.Packages.Core.Domain.Values.Ids
{
    public class LocationId : GuidId
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}