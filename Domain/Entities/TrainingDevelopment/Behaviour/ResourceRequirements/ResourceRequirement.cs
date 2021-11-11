using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirement : BehaviourItem
    {
        public GuidId ResourceTypeId { get; private set; }
        public int? Quantity { get; private set; }

        public ResourceRequirement(GuidId resourceTypeId, int? quantity)
        {
            ResourceTypeId = resourceTypeId;
            Quantity = quantity;
        }

        public void SetResourceTypeId(AuditRecord audit, GuidId id)
        {
            ResourceTypeId = id;
            OnChanged(audit);
        }

        public void SetQuantity(AuditRecord audit, int? quantity)
        {
            Quantity = quantity;
            OnChanged(audit);
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