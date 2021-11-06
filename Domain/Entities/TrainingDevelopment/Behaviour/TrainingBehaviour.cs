using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class TrainingBehaviour : ITrainingBehaviour
    {
        public GuidId Id { get; private set; }
        public TrainingEntity Owner { get; }
    }
}