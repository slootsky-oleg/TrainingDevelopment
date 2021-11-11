using System;
using System.Collections.Generic;
using Bks.Packages.Domain.Values;

namespace Bks.Packages.Domain.Entities.Behaviors
{
    public interface IBehaviorContainer<T> : ICollection<T>
        where T : IBehaviorItem
    {
        event EventHandler<AuditRecord> OnChange;
    }
}