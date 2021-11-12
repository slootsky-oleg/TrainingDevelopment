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

        protected void NotifyChanged(UserFootprint footprint)
        {
            var @event = new ChangeEventArgs(footprint);
            Changed?.Invoke(this, @event);
        }

        protected void NotifyChanged(UserFootprint footprint, Action action)
        {
            NotifyChanged(footprint);
            action.Invoke();
        }

        private T NotifyChanged<T>(UserFootprint footprint, Func<T> action)
        {
            NotifyChanged(footprint);
            return action.Invoke();
        }
    }
}