using System;

namespace Bks.TrainingDevelopment.Application.Common.Queries.Get
{
    public abstract class AbstractGetEntityRequest
    {
        public Guid Id { get; set; }
    }
}