using Domain.Values.Ids;

namespace Domain.Entities.Operational.Scheduling
{
    //TODO: Find a better name
    public abstract class SchedulableEntity : BaseEntity 
    {
        public DateRange DateRange { get; set; }
        public LocationId LocationId { get; set; }
        public ParticipantContainer Participants { get; set; }

        public ResourceContainer Resources { get; set; }
    }
}