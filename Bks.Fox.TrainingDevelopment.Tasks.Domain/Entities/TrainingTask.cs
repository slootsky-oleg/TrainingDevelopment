using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions;
using Bks.Packages.Domain.Entities;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TrainingTask : TrainingEntity
    {
        public TrainingTask(UserFootprint footprint, Name name, TypeId typeId)
            : base(footprint, name, typeId)
        {
        }

        protected override void ValidateCanBeModified()
        {
        }
    }
}