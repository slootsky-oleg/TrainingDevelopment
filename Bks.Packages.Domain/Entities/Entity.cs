using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;
using System;

namespace Bks.Fox.Domain.Entities
{
    public abstract class Entity
    {
        public GuidId Id { get; private set; }
        public ExternalId ExternalId { get; private set; }
        public Name Name { get; private set; }
        public Description Description { get; private set; }

        protected Entity(Name name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public virtual void SetDescription(UserFootprint footprint, Description description)
        {
            Description = description;
        }

        public virtual void SetExternalId(UserFootprint footprint, ExternalId externalId)
        {
            ExternalId = externalId;
        }

        public virtual void SetName(UserFootprint footprint, Name name)
        {
            Name = name;
        }
    }
}