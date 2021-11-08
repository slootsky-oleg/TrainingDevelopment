using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class TrainingBehaviour : ITrainingBehavior
    {
        //TODO: set in EF before save or in a container. Use reflection
        public GuidId OwnerId { get; private set; }
        public GuidId Id { get; private set; }
    }
}