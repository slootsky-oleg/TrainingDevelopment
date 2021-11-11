using Bks.Packages.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.Operational.Scheduling
{
    public class UnitParticipant
    {
        public UnitId Id { get; set; }
        public SeatId SeatId { get; set; }
    }
}