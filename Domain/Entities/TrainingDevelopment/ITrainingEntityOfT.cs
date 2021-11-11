using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment
{
    public interface ITrainingEntity<TResourceRequirement> : 
        ITrainingEntity,
        IHasResourceRequirements<TResourceRequirement>
        where TResourceRequirement : ResourceRequirement
    {
    }
}