using Bks.Training.Development.Domain.Values.Ids;

namespace Bks.Training.Development.Domain.Entities.Operational.Scheduling
{
    public class IndividualParticipant
    {
        public IndividualId Id { get; set; }
        public SeatId SeatId { get; set; }
    }
}