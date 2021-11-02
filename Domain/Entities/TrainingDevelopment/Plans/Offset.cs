using System;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Plans
{
    public class Offset
    {
        public GuidId PreviousActivityId { get; set; }
        public DateTime Duration { get; set; }
    }
}