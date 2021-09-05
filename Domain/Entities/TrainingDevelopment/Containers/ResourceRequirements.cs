using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment.Containers
{
    public class ResourceRequirements
    {
        //TODO: define
        public AggregationStrategy Strategy { get; set; }
        public IReadOnlyCollection<ResourceRequirement> Requirements { get; set; }
    }
}