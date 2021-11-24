using System;
using Bks.Domain.Entities;

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