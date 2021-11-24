
using Bks.Fox.Entities.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.Operational.Scheduling
{
    public class IndividualParticipant
    {
        public IndividualId Id { get; set; }
        public SeatId SeatId { get; set; }
    }
}