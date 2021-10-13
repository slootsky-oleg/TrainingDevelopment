using System.Collections.Generic;
using Domain.Atis.Entities.TrainingDevelopment.Behaviour;
using Domain.Entities.TrainingDevelopment.Tasks;

namespace Domain.Atis.Entities.TrainingDevelopment
{
    public class AtisTask: AbstractTask<AtisResourceRequirement>
    {
        public IReadOnlyCollection<AtisStep> Steps_Q { get; set; }
    }
}