using Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Domain.Atis.Entities.TrainingDevelopment
{
    public class AtisStep : Step
    {
        public bool IsLeader_Q { get; set; }
        public bool IsCritical_Q { get; set; }
    }
}