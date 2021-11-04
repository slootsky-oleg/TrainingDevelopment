using System.Collections.Generic;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirementsContainer<T>
        where T : ResourceRequirement
    {
        public AggregationStrategy Strategy { get; set; }

        public IReadOnlyCollection<T> OwnRequirements { get; set; }

        public IReadOnlyCollection<T> GetRequirements()
        {
            //TODO: Implement collecting bottom-up and combined requirements
            throw new System.NotImplementedException();
        }

        //TODO: Primary and alternative requirements
        //TODO: Additional resources
    }
}