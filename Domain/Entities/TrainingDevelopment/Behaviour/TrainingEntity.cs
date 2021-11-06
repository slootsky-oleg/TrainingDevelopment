using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Content;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.CustomFields;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Versioning;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class TrainingEntity : ITrainingEntity, IHasCustomFields, IHasContent, IVersionable
    {
        public GuidId Id { get; private set; }
        public Version Version { get; }
        public ExternalId ExternalId { get; private set; }
        public Description Description { get; }
        public Name Name { get; private set; }

        //Common for all training dev entities
        public CustomFieldContainer CustomFields { get; }
        public ContentContainer Content { get; }
    }
}