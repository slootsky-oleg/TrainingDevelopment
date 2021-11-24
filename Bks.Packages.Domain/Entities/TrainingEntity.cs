using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Entities
{
    public abstract class TrainingEntity : BaseTrainingEntity<ResourceRequirement>
    {
        protected TrainingEntity(UserFootprint footprint, Name name, TypeId typeId)
            : base(footprint, name, typeId)
        {
        }
    }
}