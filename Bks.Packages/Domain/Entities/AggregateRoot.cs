using System;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Entities
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

        protected AggregateRoot(AuditRecord audit, Name name)
        {
            Name = name;
            CreatedBy = audit.UserId;
            CreatedOn = audit.Timestamp;
        }

        public void SetExternalId(AuditRecord audit, ExternalId externalId)
        {
            ExternalId = externalId;
            AuditModification(audit);
        }

        public void SetName(AuditRecord audit, Name name)
        {
            Name = name;
            AuditModification(audit);
        }

        public void SetDescription(AuditRecord audit, Description description)
        {
            Description = description;
            AuditModification(audit);
        }

        public abstract void ValidateCanBeModified();

        protected virtual void AuditModification(AuditRecord audit)
        {
            ModifiedBy = audit.UserId;
            ModifiedOn = audit.Timestamp;
        }
    }
}