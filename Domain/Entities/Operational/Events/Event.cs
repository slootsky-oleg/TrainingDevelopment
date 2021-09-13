using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Values.Ids;

namespace Domain.Entities.Operational.Events
{
    public class Event : OperationalEntity
    {
        //TODO: extract to ParticipableEntity
        public DateRange DateRange { get; set; }
        public LocationId LocationId { get; set; }
        public ParticipantContainer Participants { get; set; }

        //TODO: Is relevant for event? May we move it to the Base entity?
        public PrerequisiteContainer Prerequisites_Q { get; set; }

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