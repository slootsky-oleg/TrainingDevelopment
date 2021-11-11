using System;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;
using Bks.TrainingDevelopment.Domain.Entities.Events;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class BehaviourItem : IBehaviorItem
    {
        public event EventHandler<AuditEventArgs> Changed;

        public GuidId Id { get; private set; }

        protected void OnChanged(AuditRecord audit)
        {
            var @event = new AuditEventArgs(audit);
            Changed?.Invoke(this, @event);
        }
    }
}