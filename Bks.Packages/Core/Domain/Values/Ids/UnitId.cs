using System;

namespace Bks.Packages.Core.Domain.Values.Ids
{
    public class UnitId : GuidId
    {
        public UnitId(Guid guid) : base(guid)
        {
        }
    }
}