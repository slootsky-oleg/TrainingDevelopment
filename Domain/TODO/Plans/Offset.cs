using System;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Domain.TrainingDevelopment.TODO.Plans
{
    public class Offset
    {
        public GuidId PreviousActivityId { get; set; }
        public DateTime Duration { get; set; }
    }
}