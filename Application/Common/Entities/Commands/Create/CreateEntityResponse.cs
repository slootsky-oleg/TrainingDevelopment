using System;
using Bks.Packages.Domain.Aggregates;
using Bks.TrainingDevelopment.Domain.Entities;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Commands.Create
{
    public class CreateEntityResponse
    {
        public Guid Id { get; }

        public CreateEntityResponse(AggregateRoot entity)
        {
            Id = entity.Id;
        }
    }
}