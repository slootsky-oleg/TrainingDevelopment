using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Domain.Entities
{
    public abstract class Entity
    {
        public GuidId Id { get; private set; }
        public ExternalId ExternalId { get; private set; }
        public Name Name { get; private set; }
        public Description Description { get; private set; }

        public void SetDescription(UserFootprint footprint, Description description)
        {
            Description = description;
            AuditModification(footprint);
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
    }
}