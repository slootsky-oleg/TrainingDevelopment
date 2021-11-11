using System;
using System.Collections;
using System.Collections.Generic;
using Bks.Packages.Domain.Entities.Notifications.Audit;

namespace Bks.Packages.Domain.Entities.Behaviors
{
    public abstract class BehaviourContainer<T> :
        IBehaviorContainer<T>,
        INotifyChanged
        where T : IBehaviorItem
    {
        private readonly List<T> items;

        public int Count => items.Count;
        public bool IsReadOnly => false;

        public event EventHandler<AuditEventArgs> Changed;

        //public IResourceRequirementSettings Settings { get; }

        protected BehaviourContainer()
        {
            items = new List<T>();
            Changed = delegate { };

            //Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        private void ItemChangeHandler(object sender, AuditEventArgs @event)
        {
            Changed?.Invoke(sender, @event);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            item.Changed += ItemChangeHandler;

            items.Add(item);
        }

        // public void Add(AuditRecord audit, T item)
        // {
        //     //validate is unique if required
        //     items.Add(item);
        //
        //     var @event = new AuditEventArgs(audit);
        //     Changed(item, @event);
        // }

        public void Clear()
        {
            items.ForEach(i => i.Changed -= ItemChangeHandler);
            items.Clear();
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            item.Changed -= ItemChangeHandler;
            return items.Remove(item);
        }
    }
}