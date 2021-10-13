using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingDevelopmentEntity
    {
        GuidId Id { get; }
        ExternalId ExternalId { get; }
        Description Description { get; }
        Name Name { get; }
    }
}