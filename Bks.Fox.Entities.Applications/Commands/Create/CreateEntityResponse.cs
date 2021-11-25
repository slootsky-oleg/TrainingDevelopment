using System;
using Bks.Fox.Domain.Entities;

namespace Bks.Fox.Application.Commands.Create
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