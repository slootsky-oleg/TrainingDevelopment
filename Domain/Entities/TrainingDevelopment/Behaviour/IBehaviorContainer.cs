using System;
using System.Collections.Generic;
using Bks.TrainingDevelopment.Domain.Values;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface IBehaviorContainer<T> : ICollection<T>
        where T : IBehaviorItem
    {
        event EventHandler<AuditRecord> OnChange;
    }
}