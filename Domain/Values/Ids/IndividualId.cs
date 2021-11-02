using System;

namespace Bks.TrainingDevelopment.Domain.Values.Ids
{
    public class IndividualId : GuidId
    {
        public IndividualId(Guid guid) : base(guid)
        {
        }
    }
}