using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Atis.Training.Development.Domain.Entities.TrainingDevelopment
{
    public class AtisStep : Step
    {
        public bool IsLeader { get; }
        public bool IsCritical { get; }
    }
}