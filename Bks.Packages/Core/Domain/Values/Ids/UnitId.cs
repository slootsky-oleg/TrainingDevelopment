using System;

namespace Bks.Packages.Core.Domain.Values.Ids
{
    public class UnitId : GuidValueObject
    {
        public UnitId(Guid guid) : base(guid)
        {
        }
    }
}