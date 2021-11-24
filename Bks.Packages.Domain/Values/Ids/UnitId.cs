using System;

namespace Bks.Practices.Ddd.Domain.Values.Ids
{
    public class UnitId : GuidValueObject
    {
        public UnitId(Guid guid) : base(guid)
        {
        }
    }
}