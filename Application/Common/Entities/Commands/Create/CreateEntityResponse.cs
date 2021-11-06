using System;
using Bks.TrainingDevelopment.Domain.Entities;

namespace Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Commands
{
    public class CreateEntityResponse
    {
        public Guid Id { get; }

        public CreateEntityResponse(IEntity entity)
        {
            Id = entity.Id;
        }
    }
}