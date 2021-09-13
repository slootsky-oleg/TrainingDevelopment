using Domain.Entities.Operational.Scheduling;

namespace Domain.Entities.Operational.Events
{
    public class Event : SchedulableEntity
    {
        public override void Archive()
        {
            throw new System.NotSupportedException();
        }

        public override void Restore()
        {
            throw new System.NotSupportedException();
        }
    }
}