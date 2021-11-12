using System.Collections.Generic;
using Bks.Packages.Core.Domain.Entities.Behaviors.Abstractions;
using Bks.Packages.Core.Domain.Values;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements
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

        public void SetResourceTypeId(UserFootprint footprint, GuidId id)
        {
            NotifyChanged(footprint, () => ResourceTypeId = id);
        }

        public void SetQuantity(UserFootprint footprint, int? quantity)
        {
            NotifyChanged(footprint, () => Quantity = quantity);
        }


        //1 laptop per 2 participants
        //public int Ratio { get; set; }

        //TODO: Metadata properties

        //TODO: Resource positions - professions/seats

        //TODO: Date range

        //TODO: Is mandatory

        //TODO: Required qualifications
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return ResourceTypeId;
        }
    }
}