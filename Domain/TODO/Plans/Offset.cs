using System;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.TODO.Plans
{
    public class Offset
    {
        public GuidId PreviousActivityId { get; set; }
        public DateTime Duration { get; set; }
    }
}