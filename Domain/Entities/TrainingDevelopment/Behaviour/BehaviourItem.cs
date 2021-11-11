using System;
using Bks.TrainingDevelopment.Domain.Entities.Events;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

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