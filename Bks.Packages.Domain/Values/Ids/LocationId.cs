using System;

namespace Bks.Fox.Entities.Domain.Values.Ids
{
    public class LocationId : GuidValueObject
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}