using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;

namespace Bks.Training.Development.Domain.Atis.Entities.TrainingDevelopment.Behaviour
{
    public class AtisResourceRequirement: ResourceRequirement
    {
        public bool IsRequired { get; }
    }
}