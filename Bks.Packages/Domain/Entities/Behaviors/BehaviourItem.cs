using System;
using Bks.Packages.Domain.Entities.Notifications.Audit;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Entities.Behaviors
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