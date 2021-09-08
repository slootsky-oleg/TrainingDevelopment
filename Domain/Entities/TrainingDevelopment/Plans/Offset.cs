using System;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Plans
{
    public class Offset
    {
        public GuidId PreviousActivityId { get; set; }
        public DateTime Duration { get; set; }
    }
}