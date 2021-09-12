using System.Collections.Generic;

namespace Domain.Entities.Operational.Events
{
    public class ParticipantContainer
    {
        public ParticipationStrategy Strategy { get; set; }
        public IReadOnlyCollection<UnitParticipant> Units { get; set; }
        public IReadOnlyCollection<IndividualParticipant> Individuals { get; set; }

    }
}