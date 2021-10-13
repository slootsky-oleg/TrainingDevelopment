using Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Domain.Atis.Entities.TrainingDevelopment
{
    public class AtisStep : Step
    {
        public bool IsLeader_Q { get; }
        public bool IsCritical_Q { get; }
    }
}