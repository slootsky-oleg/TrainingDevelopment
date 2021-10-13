using System.Collections.Generic;

namespace Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirementsContainer
    {
        public AggregationStrategy Strategy { get; set; }

        public IReadOnlyCollection<ResourceRequirement> OwnRequirements { get; set; }

        public IReadOnlyCollection<ResourceRequirement> GetRequirements()
        {
            //TODO: Implement collecting bottom-up and combined requirements
            throw new System.NotImplementedException();
        }

        //TODO: Primary and alternative requirements
        //TODO: Additional resources
    }
}