using Bks.Fox.Domain.Behaviors.ResourceRequirements;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities
{
    public abstract class TrainingEntity : BaseTrainingEntity<ResourceRequirement>
    {
        protected TrainingEntity(UserFootprint footprint, Name name, TypeId typeId)
            : base(footprint, name, typeId)
        {
        }
    }
}