using System;
using Bks.TrainingDevelopment.Domain.Entities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;

namespace Bks.TrainingDevelopment.Application.Common.Queries
{
    public abstract class AbstractGetEntityResponse
    {
        public Guid Id { get; }
        public string ExternalId { get; }
        public string Name { get; }
        public string Description { get; }

        protected AbstractGetEntityResponse(IEntity entity)
        {
            Id = entity.Id;
            ExternalId = entity.ExternalId;
            Name = entity.Name;
            Description = entity.Description;
        }
    }
}