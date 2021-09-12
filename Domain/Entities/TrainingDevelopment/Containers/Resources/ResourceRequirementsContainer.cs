using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment.Containers.Resources
{
    public class ResourceRequirementsContainer
    {
        //TODO: define AggregationStrategy
        public AggregationStrategy Strategy { get; set; }

        //TODO: 
        public IReadOnlyCollection<ResourceRequirement> OwnRequirements { get; set; }

        public IReadOnlyCollection<ResourceRequirement> GetRequirements()
        {
            //TODO: Implement collecting bottom-up and combined requirements
            throw new System.NotImplementedException();
        }

        //TODO: ResourceRequirementsContainer - Primary and alternative requirements
        //TODO: ResourceRequirementsContainer - Additional resources
    }
}