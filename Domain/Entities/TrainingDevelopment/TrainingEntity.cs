using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;
using Bks.Practices.Ddd.Domain.Values;
using Bks.Practices.Ddd.Domain.Values.Ids;

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