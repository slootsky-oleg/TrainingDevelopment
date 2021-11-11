namespace Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements
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