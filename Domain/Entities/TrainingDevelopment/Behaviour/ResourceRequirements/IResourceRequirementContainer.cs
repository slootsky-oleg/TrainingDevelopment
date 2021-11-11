namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public interface IResourceRequirementContainer<T> : IBehaviorContainer<T>
        where T : ResourceRequirement
    {
        //IReadOnlyCollection<T> GetAll();
        // void Add(T requirement);
        // void Remove(T requirement);
        // void Update<TCommand>(TCommand command);
    }
}