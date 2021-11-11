using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Aggregates
{
    public abstract class Entity
    {
        public GuidId Id { get; private set; }
        public ExternalId ExternalId { get; private set; }
        public Name Name { get; private set;}
        public Description Description { get; private set;}

        protected Entity(Name name)
        {
            Name = name;
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
        public abstract void AuditModification(AuditRecord audit);
    }
}