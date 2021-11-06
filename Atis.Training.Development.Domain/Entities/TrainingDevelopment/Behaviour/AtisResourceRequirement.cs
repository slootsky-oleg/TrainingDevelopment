using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;

namespace Atis.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public class AtisResourceRequirement : ResourceRequirement
    {
        public bool IsRequired { get; }
    }
}