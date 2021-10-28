using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Bks.Training.Development.Domain.Atis.Entities.TrainingDevelopment
{
    public class AtisStep : Step
    {
        public bool IsLeader_Q { get; }
        public bool IsCritical_Q { get; }
    }
}