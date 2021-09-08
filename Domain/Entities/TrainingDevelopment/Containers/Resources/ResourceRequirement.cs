using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Containers.Resources
{
    public class ResourceRequirement
    {
        public EntityTypeId ResourceTypeId { get; set; }
        public int? Quantity { get; set; }
        
        //1 laptop per 2 participants
        public int Ratio { get; set; }
    }
}