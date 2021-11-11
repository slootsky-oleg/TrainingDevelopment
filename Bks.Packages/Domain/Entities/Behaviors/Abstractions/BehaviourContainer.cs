using System;
using System.Collections;
using System.Collections.Generic;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements.Settings;
using Bks.Packages.Domain.Entities.Notifications.Audit;

namespace Bks.Packages.Domain.Entities.Behaviors.Abstractions
{
    public abstract class BehaviourContainer<T> :
        IBehaviorContainer<T>,
        INotifyChanged
        where T : IBehaviorItem
    {
        protected readonly List<T> Items;

        public int Count => Items.Count;
        public bool IsReadOnly => false;

        public event EventHandler<AuditEventArgs> Changed;

        public IBehaviorContainerSettings Settings { get; }

        protected BehaviourContainer(/*IBehaviorContainerSettings settings*/)
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

        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            // if (Settings.RequireUnique && Items.Contains(item))
            // {
            //     throw new NotUniqueException()
            // }

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

        public bool Remove(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            item.Changed -= ItemChangeHandler;
            return Items.Remove(item);
        }

        private void ItemChangeHandler(object sender, AuditEventArgs @event)
        {
            Changed?.Invoke(sender, @event);
        }
    }
}