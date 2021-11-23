using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Packages.TrainingDevelopment.Domain.Entities
{
    public interface ITrainingDevelopmentEntity :
        IHasResourceRequirements<ResourceRequirement>
    {
    }
}