using System.Collections.Generic;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements.Settings;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirementsContainer<T>
        where T : ResourceRequirement
    {
        public AggregationStrategy Strategy { get; }
        public IResourceRequirementSettings Settings { get; set; }
        public IReadOnlyCollection<T> OwnRequirements { get; }

        public IReadOnlyCollection<T> GetRequirements()
        {
            //TODO: Implement collecting bottom-up and combined requirements
            throw new System.NotImplementedException();
        }

        //TODO: Primary and alternative requirements
        //TODO: Additional resources
    }
}