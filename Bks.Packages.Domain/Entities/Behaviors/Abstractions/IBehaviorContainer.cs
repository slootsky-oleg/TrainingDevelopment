using System;
using System.Collections.Generic;
using Bks.Packages.Domain.Entities.Notifications.Changes;

namespace Bks.Packages.Domain.Entities.Behaviors.Abstractions
{
    public interface IBehaviorContainer<T, in TSettings> : ICollection<T>
        where T : IBehaviorItem
        where TSettings : IBehaviorContainerSettings
    {
        event EventHandler<ChangeEventArgs> Changed;

        void ApplySettings(TSettings settings);
    }
}