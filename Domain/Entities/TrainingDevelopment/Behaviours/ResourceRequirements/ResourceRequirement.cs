using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Behaviours.ResourceRequirements
{
    public class ResourceRequirement
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