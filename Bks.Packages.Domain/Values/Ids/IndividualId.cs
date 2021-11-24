using System;

namespace Bks.Practices.Ddd.Domain.Values.Ids
{
    public class IndividualId : GuidId
    {
        public IndividualId(Guid guid) : base(guid)
        {
        }
    }
}