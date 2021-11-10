using System;
using System.Collections.Generic;
using Bks.TrainingDevelopment.Domain.Values;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public interface IBehaviorContainer<T> : ICollection<T>
        where T : ITrainingBehavior
    {
        event EventHandler<AuditRecord> OnChange;
    }
}