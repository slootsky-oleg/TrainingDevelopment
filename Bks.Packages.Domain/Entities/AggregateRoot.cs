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
            : base(name)

        {
            CreatedBy = footprint.UserId;
            CreatedOn = footprint.Timestamp;
        }

        protected abstract void ValidateCanBeModified();

        public override void SetDescription(UserFootprint footprint, Description description)
        {
            base.SetDescription(footprint, description);
            AuditModification(footprint);
        }

        public override void SetExternalId(UserFootprint footprint, ExternalId externalId)
        {
            base.SetExternalId(footprint, externalId);
            AuditModification(footprint);
        }

        public override void SetName(UserFootprint footprint, Name name)
        {
            base.SetName(footprint, name);
            AuditModification(footprint);
        }


        protected virtual void AuditModification(UserFootprint footprint)
        {
            ModifiedBy = footprint.UserId;
            ModifiedOn = footprint.Timestamp;
        }
    }
}