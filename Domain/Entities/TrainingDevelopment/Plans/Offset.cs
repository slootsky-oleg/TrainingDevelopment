using System;
using Bks.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Plans
{
    public class Offset
    {
        public GuidId PreviousActivityId { get; set; }
        public DateTime Duration { get; set; }
    }
}