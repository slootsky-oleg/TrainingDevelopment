using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Queries.Models
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