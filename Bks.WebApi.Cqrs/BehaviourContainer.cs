using System;
using System.Collections;
using System.Collections.Generic;
using Bks.Fox.Domain.Notifications.Changes;

namespace Bks.Fox.Behaviors.Domain
{
    public class BehaviourContainer<T> :
        IBehaviorContainer<T>,
        INotifyEntityChanged
        where T : INotifyEntityChanged
    {
        protected readonly List<T> Items;

        public int Count => Items.Count;
        public bool IsReadOnly => false;

        public event EventHandler<ChangeEventArgs> Changed;

        public BehaviourContainer(/*IBehaviorContainerSettings settings*/)
        {
            Items = new List<T>();
            Changed = delegate { };

            //Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public virtual void Add(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            item.Changed += ItemChangeHandler;
            Items.Add(item);
        }

        public void Clear()
        {
            Items.ForEach(i => i.Changed -= ItemChangeHandler);
            Items.Clear();
        }

        public bool Contains(T item)
        {
            return Items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Items.CopyTo(array, arrayIndex);
        }

        public virtual bool Remove(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            item.Changed -= ItemChangeHandler;
            return Items.Remove(item);
        }

        private void ItemChangeHandler(object sender, ChangeEventArgs @event)
        {
            Changed?.Invoke(sender, @event);
        }
    }
}