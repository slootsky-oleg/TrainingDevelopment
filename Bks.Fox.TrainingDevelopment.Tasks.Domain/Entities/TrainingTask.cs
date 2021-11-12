using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment;
using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TrainingTask : TrainingEntity<ResourceRequirement>
    {
        public TrainingTask(UserFootprint footprint, Name name, TypeId typeId)
            : base(footprint, name, typeId)
        {
        }

        public override void ValidateCanBeModified()
        {
        }
    }
}