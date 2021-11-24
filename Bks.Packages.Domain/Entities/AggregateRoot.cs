using System;
using Bks.Practices.Ddd.Domain.Values;
using Bks.Practices.Ddd.Domain.Values.Ids;

namespace Bks.Practices.Ddd.Domain.Entities
{
    public abstract class AggregateRoot
    {
        public GuidId Id { get; private set; }
        public ExternalId ExternalId { get; private set; }
        public Name Name { get; private set;}
        public Description Description { get; private set;}

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

        public void SetExternalId(UserFootprint footprint, ExternalId externalId)
        {
            ExternalId = externalId;
            AuditModification(footprint);
        }

        public void SetName(UserFootprint footprint, Name name)
        {
            Name = name;
            AuditModification(footprint);
        }

        public void SetDescription(UserFootprint footprint, Description description)
        {
            Description = description;
            AuditModification(footprint);
        }

        protected abstract void ValidateCanBeModified();

        protected virtual void AuditModification(UserFootprint footprint)
        {
            ModifiedBy = footprint.UserId;
            ModifiedOn = footprint.Timestamp;
        }
    }
}