using System.Collections.Generic;
using Domain.Entities.TrainingDevelopment.Tasks;

namespace Domain.Atis.Entities.TrainingDevelopment
{
    public class AtisTask: Task_Q
    {
        public IReadOnlyCollection<AtisStep> Steps { get; set; }
    }
}