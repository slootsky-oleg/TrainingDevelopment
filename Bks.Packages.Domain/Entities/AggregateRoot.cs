using System;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Domain.Entities
{
    public abstract class AggregateRoot : Entity
    {
        public UserId CreatedBy { get; }
        public DateTime CreatedOn { get; }
        public UserId ModifiedBy { get; private set; }
        public DateTime ModifiedOn { get; private set; }

        protected AggregateRoot(UserFootprint footprint, Name name)
        {
            Name = name;
            CreatedBy = footprint.UserId;
            CreatedOn = footprint.Timestamp;
        }

        protected abstract void ValidateCanBeModified();

        protected virtual void AuditModification(UserFootprint footprint)
        {
            ModifiedBy = footprint.UserId;
            ModifiedOn = footprint.Timestamp;
        }
    }
}