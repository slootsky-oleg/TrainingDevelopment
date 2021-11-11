using System;

namespace Bks.Packages.Domain.Values.Ids
{
    public class IndividualId : GuidId
    {
        public IndividualId(Guid guid) : base(guid)
        {
        }
    }
}