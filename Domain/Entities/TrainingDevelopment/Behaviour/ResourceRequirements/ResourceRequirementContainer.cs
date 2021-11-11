using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements.Settings;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirementContainer<T> : IResourceRequirementContainer<T>
        where T : ResourceRequirement
    {
        private readonly List<T> items;

        public int Count => items.Count;
        public bool IsReadOnly => false;

        public event EventHandler<AuditRecord> OnChange;

        public IResourceRequirementSettings Settings { get; }

        public ResourceRequirementContainer(
            IResourceRequirementSettings settings)
        {
            items = new List<T>();
            OnChange = delegate { };

            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
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
            //validate is unique if required
            OnChange += (sender, audit) => OnChange(sender, audit);
            items.Add(item);
        }

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
            OnChange -= (sender, audit) => OnChange(sender, audit);
            return items.Remove(item);
        }
    }
}