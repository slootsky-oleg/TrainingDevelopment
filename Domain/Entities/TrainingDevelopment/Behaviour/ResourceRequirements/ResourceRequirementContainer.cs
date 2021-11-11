using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using Bks.Packages.Domain.Entities.Notifications.Audit;
using Bks.Packages.Domain.Values;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements.Settings;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirementContainer<T> : IResourceRequirementContainer<T>
        where T : ResourceRequirement
    {
        private readonly List<T> items;

        public int Count => items.Count;
        public bool IsReadOnly => false;

        public event EventHandler<AuditEventArgs> Changed;

        public IResourceRequirementSettings Settings { get; }

        public ResourceRequirementContainer(
            IResourceRequirementSettings settings)
        {
            items = new List<T>();
            Changed = delegate { };

            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        private void ItemChangeHandler(object sender, AuditEventArgs @event)
        {
            Changed(sender, @event);
        }


        //TODO: Primary and alternative requirements
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
            //Changed -= (sender, audit) => Changed(sender, audit);
            return items.Remove(item);
        }
    }
}