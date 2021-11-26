using System;
using System.Collections.Generic;
using System.Threading.Channels;
using Bks.Fox.Behaviors.Domain;
using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Behaviors.ResourceRequirements.Domain
{
    public class ResourceRequirement : ValueObject, INotifyEntityChanged
    {
        public event EventHandler<ChangeEventArgs> Changed;

        public Guid Id { get; private set; }
        public GuidId ResourceTypeId { get; private set; }
        public int? Quantity { get; private set; }

        public ResourceRequirement(GuidId resourceTypeId, int? quantity)
        {
            ResourceTypeId = resourceTypeId;
            Quantity = quantity;
        }

        public void SetResourceTypeId(UserFootprint footprint, GuidId id)
        {
            Notify(footprint);
            ResourceTypeId = id;
        }

        public void SetQuantity(UserFootprint footprint, int? quantity)
        {
            Notify(footprint);
            Quantity = quantity;
        }

        private void Notify(UserFootprint footprint)
        {
            Changed?.Notify(this, footprint);
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