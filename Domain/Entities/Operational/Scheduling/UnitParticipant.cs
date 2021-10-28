using Bks.Training.Development.Domain.Values.Ids;

namespace Bks.Training.Development.Domain.Entities.Operational.Scheduling
{
    public class UnitParticipant
    {
        public UnitId Id { get; set; }
        public SeatId SeatId { get; set; }
    }
}