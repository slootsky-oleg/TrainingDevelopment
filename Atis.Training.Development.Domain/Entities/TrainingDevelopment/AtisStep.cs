using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Atis.Training.Development.Domain.Entities.TrainingDevelopment
{
    public class AtisStep : Step
    {
        public bool IsLeader_Q { get; }
        public bool IsCritical_Q { get; }
    }
}