using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Content;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.CustomFields;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Versioning;
using Bks.Training.Development.Domain.Values;
using Bks.Training.Development.Domain.Values.Ids;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour
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