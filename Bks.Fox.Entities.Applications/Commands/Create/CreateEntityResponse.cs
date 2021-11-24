using System;
using Bks.Fox.Entities.Domain.Entities;

namespace Bks.Fox.Entities.Applications.Commands.Create
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