using System;
using Bks.Fox.Entities.Applications.Commands.Create;

namespace Bks.Packages.TrainingDevelopment.Application.Entities.Commands.Create
{
    public abstract class CreateTrainingEntityRequest : CreateEntityRequest
    {
        public Guid TypeId { get; set; }
    }
}