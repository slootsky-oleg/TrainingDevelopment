using Domain.Entities.Operational.Scheduling;

namespace Domain.Entities.Operational.Events
{
    public class Event : SchedulableEntity
    {
        public override void Archive_Q()
        {
            throw new System.NotSupportedException("Step can't be archived.");  //Applies to all availability methods
        }
    }
}