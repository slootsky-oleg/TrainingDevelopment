using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingBehaviour
    {
        GuidId Id { get; }
        TrainingEntity Owner { get; }
    }
}