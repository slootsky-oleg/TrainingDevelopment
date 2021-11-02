using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingEntity
    {
        GuidId Id { get; }
        ExternalId ExternalId { get; }
        Name Name { get; }
        Description Description { get; }
    }
}