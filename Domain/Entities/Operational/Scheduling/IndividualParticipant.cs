using Domain.Values.Ids;

namespace Domain.Entities.Operational.Scheduling
{
    public class IndividualParticipant
    {
        public IndividualId Id { get; set; }
        public SeatId SeatId { get; set; }
    }
}