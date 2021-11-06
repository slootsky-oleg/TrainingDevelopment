using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class TrainingBehaviour : ITrainingBehavior
    {
        public GuidId Id { get; private set; }
    }
}