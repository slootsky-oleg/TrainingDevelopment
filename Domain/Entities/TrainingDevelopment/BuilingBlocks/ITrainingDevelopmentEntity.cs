using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.BuilingBlocks
{
    public interface ITrainingDevelopmentEntity
    {
        GuidId Id { get; set; }
        ExternalId ExternalId { get; set; }
        Description Description { get; set; }
        Name Name { get; set; }
    }
}