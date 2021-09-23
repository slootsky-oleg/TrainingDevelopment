using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Abstractions
{
    public interface ITrainingDevelopmentEntity
    {
        GuidId Id { get; set; }
        ExternalId ExternalId { get; set; }
        Description Description { get; set; }
        Name Name { get; set; }
    }
}