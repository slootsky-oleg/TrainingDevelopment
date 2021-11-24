using Bks.Domain.Values;
using Bks.Domain.Values.Ids;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment
{
    public abstract class TrainingEntity : BaseTrainingEntity<ResourceRequirement>
    {
        protected TrainingEntity(UserFootprint footprint, Name name, TypeId typeId)
            : base(footprint, name, typeId)
        {
        }
    }
}