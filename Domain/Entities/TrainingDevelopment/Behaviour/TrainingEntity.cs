using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Content;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.CustomFields;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Versioning;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class TrainingEntity : Entity, IHasCustomFields, IHasContent, IVersionable
    {
        public Version Version { get; }

        //Common for all training dev entities
        public CustomFieldContainer CustomFields { get; }
        public ContentContainer Content { get; }
    }
}