using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirement : TrainingBehaviour
    {
        public GuidId ResourceTypeId { get; }

        public int? Quantity { get; }

        public ResourceRequirement(GuidId resourceTypeId, int? quantity)
        {
            ResourceTypeId = resourceTypeId;
            Quantity = quantity;
        }

        //1 laptop per 2 participants
        //public int Ratio { get; set; }

        //TODO: Metadata properties

        //TODO: Resource positions - professions/seats

        //TODO: Date range

        //TODO: Is mandatory

        //TODO: Required qualifications
    }
}