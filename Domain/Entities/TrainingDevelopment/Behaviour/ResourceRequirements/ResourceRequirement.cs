using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirement: TrainingBehaviour
    {
        public EntityTypeId ResourceTypeId { get; set; }

        public int? Quantity { get; set; }
        
        //1 laptop per 2 participants
        public int Ratio { get; set; }

        //TODO: Metadata properties

        //TODO: Resource positions - professions/seats

        //TODO: Date range

        //TODO: Is mandatory

        //TODO: Required qualifications
    }
}