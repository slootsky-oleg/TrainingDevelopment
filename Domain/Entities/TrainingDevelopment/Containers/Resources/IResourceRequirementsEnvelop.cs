using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment.Containers.Resources
{
    public interface IResourceRequirementsEnvelop
    {
        AggregationStrategy Strategy { get; }
        IReadOnlyCollection<ResourceRequirement> GetRequirements();
    }
}