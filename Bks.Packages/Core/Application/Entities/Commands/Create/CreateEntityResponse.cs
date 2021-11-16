using System;
using Bks.Packages.Core.Domain.Entities;

namespace Bks.Packages.Core.Application.Entities.Commands.Create
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