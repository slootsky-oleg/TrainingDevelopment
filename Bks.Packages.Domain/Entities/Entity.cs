using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;
using System;

namespace Bks.Fox.Domain.Entities
{
    //TODO: implement comparers
    public abstract class Entity
    {
        public GuidId Id { get; private set; }
        public ExternalId ExternalId { get; protected set; }
    }
}