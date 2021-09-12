using Domain.Entities.TrainingDevelopment.Containers;

namespace Domain.Entities.Operational.Events
{
    public class Event : OperationalEntity
    {
        //TODO: extract to ParticipableEntity
        public DateRange DateRange { get; set; }
        public ParticipantContainer Participants { get; set; }

        //TODO: Define allocated resources
        public ResourceContainer Resources { get; set; }

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