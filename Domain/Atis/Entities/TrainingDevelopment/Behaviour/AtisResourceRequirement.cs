using Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;

namespace Domain.Atis.Entities.TrainingDevelopment.Behaviour
{
    public class AtisResourceRequirement: ResourceRequirement
    {
        public bool IsRequired { get; }
    }
}