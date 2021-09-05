using System;

namespace Domain.Values.Ids
{
    public class EntityTypeId : GuidId
    {
        public EntityTypeId(Guid guid) : base(guid)
        {
        }
    }
}