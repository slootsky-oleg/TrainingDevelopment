using System;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Domain.Entities
{
    public abstract class AggregateRoot : Entity
    {
        public Name Name { get; private set; }
        public Description Description { get; private set; }

        public UserId CreatedBy { get; }
        public DateTime CreatedOn { get; }
        public UserId ModifiedBy { get; private set; }
        public DateTime ModifiedOn { get; private set; }

        protected AggregateRoot(UserFootprint footprint, Name name)

        {
            if (footprint == null) throw new ArgumentNullException(nameof(footprint));
            Name = name ?? throw new ArgumentNullException(nameof(name));

            CreatedBy = footprint.UserId;
            CreatedOn = footprint.Timestamp;
        }

        protected abstract void ValidateCanBeModified();

        public void SetDescription(UserFootprint footprint, Description description)
        {
            ValidateCanBeModified();

            Description = description;

            AuditModification(footprint);
        }

        public void SetExternalId(UserFootprint footprint, ExternalId externalId)
        {
            ValidateCanBeModified();

            ExternalId = externalId;

            AuditModification(footprint);
        }

        public void SetName(UserFootprint footprint, Name name)
        {
            ValidateCanBeModified();

            Name = name;

            AuditModification(footprint);
        }


        protected virtual void AuditModification(UserFootprint footprint)
        {
            ModifiedBy = footprint.UserId;
            ModifiedOn = footprint.Timestamp;
        }
    }
}