using System;
using Bks.Packages.Domain.Entities;
using Bks.TrainingDevelopment.Domain.Entities;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Queries.Get
{
    public abstract class AbstractGetEntityResponse
    {
        public Guid Id { get; }
        public string ExternalId { get; }
        public string Name { get; }
        public string Description { get; }

        protected AbstractGetEntityResponse(AggregateRoot entity)
        {
            Id = entity.Id;
            ExternalId = entity.ExternalId;
            Name = entity.Name;
            Description = entity.Description;
        }
    }
}