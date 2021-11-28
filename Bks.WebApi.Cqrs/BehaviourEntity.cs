using System;
using Bks.Fox.Domain.Entities;
using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values;

namespace Bks.Fox.Behaviors.Domain
{
    public abstract class BehaviourEntity : Entity, INotifyEntityChanged
    {
        public event EventHandler<ChangeEventArgs> Changed;

        protected void Notify(UserFootprint footprint, Action action)
        {
            action.Invoke();

            var @event = new ChangeEventArgs(footprint);
            Notify(this, @event);
        }
        
        protected void Notify(object sender, ChangeEventArgs @event)
        {
            Changed?.Invoke(this, @event);
        }

        protected void ChangeHandler(object sender, ChangeEventArgs @event)
        {
            Changed?.Invoke(sender, @event);
        }
    }
}