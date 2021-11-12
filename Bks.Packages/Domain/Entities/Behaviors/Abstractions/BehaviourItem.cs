using System;
using Bks.Packages.Domain.Entities.Notifications.Changes;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Entities.Behaviors.Abstractions
{
    public abstract class BehaviourItem : ValueObject, IBehaviorItem
    {
        public event EventHandler<ChangeEventArgs> Changed;

        public GuidId Id { get; private set; }

        protected void OnChanged(UserFootprint footprint)
        {
            var @event = new ChangeEventArgs(footprint);
            Changed?.Invoke(this, @event);
        }
    }
}