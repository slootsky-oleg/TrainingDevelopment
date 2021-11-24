using System;
using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Domain.Behaviors
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