using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Content;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.CustomFields;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Versioning;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class TrainingEntity : ITrainingEntity, IHasCustomFields, IHasContent, IVersioned
    {
        public GuidId Id { get; }
        public Version Version_Q { get; }
        public ExternalId ExternalId { get; }
        public Description Description { get; }
        public Name Name { get; }

        //Common for all training dev entities
        public CustomFieldContainer CustomFields_Q { get; }
        public ContentContainer_Q Content_Q { get; }
    }

}