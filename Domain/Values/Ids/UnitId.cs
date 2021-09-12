using System;
using System.Collections.Generic;

namespace Domain.Values.Ids
{
    public class UnitId : GuidId
    {
        public UnitId(Guid guid) : base(guid)
        {
        }
    }
}