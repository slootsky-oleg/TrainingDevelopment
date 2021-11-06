using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities
{
    public abstract class Entity
    {
        public GuidId Id { get; }
        public ExternalId ExternalId { get; }
        public Name Name { get; }
        public Description Description { get; }
    }
}