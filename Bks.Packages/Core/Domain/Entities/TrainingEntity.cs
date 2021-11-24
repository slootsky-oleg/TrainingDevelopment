using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Packages.Core.Domain.Entities
{
    public abstract class TrainingEntity : BaseTrainingEntity<ResourceRequirement>
    {
        protected TrainingEntity(UserFootprint footprint, Name name, TypeId typeId)
            : base(footprint, name, typeId)
        {
        }
    }
}