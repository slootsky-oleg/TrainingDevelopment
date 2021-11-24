using System;

namespace Bks.Fox.Domain.Values.Ids
{
    public class IndividualId : GuidId
    {
        public IndividualId(Guid guid) : base(guid)
        {
        }
    }
}