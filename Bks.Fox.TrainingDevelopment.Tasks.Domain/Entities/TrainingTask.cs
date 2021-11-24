using Bks.Fox.Entities.Domain.Values;
using Bks.Fox.Entities.Domain.Values.Ids;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment;
using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions;

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