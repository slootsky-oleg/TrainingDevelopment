using System;

namespace Bks.Packages.Core.Domain.Values.Ids
{
    public class LocationId : GuidValueObject
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}