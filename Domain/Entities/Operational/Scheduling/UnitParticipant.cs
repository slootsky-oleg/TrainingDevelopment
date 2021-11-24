using Bks.Practices.Ddd.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.Operational.Scheduling
{
    public class UnitParticipant
    {
        public UnitId Id { get; set; }
        public SeatId SeatId { get; set; }
    }
}