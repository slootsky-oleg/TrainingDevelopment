namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public interface IHasResourceRequirements<TRequirement>
        where TRequirement : ResourceRequirement
    {
        ResourceRequirementContainer<TRequirement> ResourceRequirements { get; }
    }
}