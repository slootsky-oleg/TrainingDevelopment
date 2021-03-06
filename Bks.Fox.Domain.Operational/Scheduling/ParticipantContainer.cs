using System.Collections.Generic;

namespace Bks.Fox.Operational.Domain.Scheduling
{
    public class ParticipantContainer
    {
        public ParticipationStrategy Strategy { get; set; }
        public IReadOnlyCollection<UnitParticipant> Units { get; set; }
        public IReadOnlyCollection<IndividualParticipant> Individuals { get; set; }
    }
}