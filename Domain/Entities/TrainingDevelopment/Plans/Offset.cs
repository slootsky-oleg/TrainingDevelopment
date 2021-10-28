using System;
using Bks.Training.Development.Domain.Values.Ids;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Plans
{
    public class Offset
    {
        public GuidId PreviousActivityId { get; set; }
        public DateTime Duration { get; set; }
    }
}