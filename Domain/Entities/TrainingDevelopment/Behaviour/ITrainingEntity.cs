using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface ITrainingEntity
    {
        GuidId Id { get; }
        ExternalId ExternalId { get; }
        Name Name { get; }
        Description Description { get; }
    }
}