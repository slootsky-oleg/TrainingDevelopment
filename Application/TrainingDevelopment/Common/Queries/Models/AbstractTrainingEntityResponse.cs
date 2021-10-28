using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.Training.Development.Domain.Values;
using Bks.Training.Development.Domain.Values.Ids;

namespace Bks.Training.Development.Application.TrainingDevelopment.Common.Queries.Models
{
    public abstract class AbstractTrainingEntityResponse
    {
        GuidId Id { get; }
        ExternalId ExternalId { get; }
        Name Name { get; }
        Description Description { get; }

        protected AbstractTrainingEntityResponse(ITrainingEntity entity)
        {
            Id = entity.Id;
            ExternalId = entity.ExternalId;
            Name = entity.Name;
            Description = entity.Description;
        }
    }
}