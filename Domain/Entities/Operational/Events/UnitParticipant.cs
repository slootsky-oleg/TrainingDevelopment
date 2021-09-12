using Domain.Values.Ids;

namespace Domain.Entities.Operational.Events
{
    public class UnitParticipant
    {
        public UnitId Id { get; set; }
        public SeatId SeatId { get; set; }
    }
}