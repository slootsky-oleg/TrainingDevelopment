using System;

namespace Bks.TrainingDevelopment.Domain.Values.Ids
{
    public class LocationId : GuidId
    {
        public LocationId(Guid guid) : base(guid)
        {
        }
    }
}