namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public interface IHasResourceRequirements<T>
        where T: ResourceRequirement
    {
        ResourceRequirementsContainer<T> ResourceRequirements { get; }
    }
}