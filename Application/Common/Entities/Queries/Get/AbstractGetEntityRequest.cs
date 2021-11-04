using System;

namespace Bks.TrainingDevelopment.Application.Common.Entities.Queries.Get
{
    public abstract class AbstractGetEntityRequest
    {
        public Guid EntityId { get; set; }
    }
}