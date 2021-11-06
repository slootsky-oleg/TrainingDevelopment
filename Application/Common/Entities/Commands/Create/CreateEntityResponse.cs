using System;
using Bks.TrainingDevelopment.Domain.Entities;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Commands.Create
{
    public class CreateEntityResponse
    {
        public Guid Id { get; }

        public CreateEntityResponse(Entity entity)
        {
            Id = entity.Id;
        }
    }
}