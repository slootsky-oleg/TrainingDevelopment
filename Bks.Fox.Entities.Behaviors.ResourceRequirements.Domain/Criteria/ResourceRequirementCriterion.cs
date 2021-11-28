using System;
using Bks.Fox.Behaviors.Domain;
using Bks.Fox.Domain.Entities;
using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Behaviors.ResourceRequirements.Domain.Criteria
{
    public class ResourceRequirementCriterion: BehaviourEntity
    {
        //TODO: Implement ordered collection
        public ItemPosition ItemPosition { get; private set; }
        public GuidId ResourceTypeId { get; private set; }
        public int? Quantity { get; private set; }

        //expressions: fieldA ==|<... value

        public void SetResourceTypeId(UserFootprint footprint, GuidId id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            Notify(footprint, () => ResourceTypeId = id);
        }
        
        public void SetQuantity(UserFootprint footprint, int? quantity)
        {
            Notify(footprint, () => Quantity = quantity);
        }

        public void SetPosition(UserFootprint footprint, ItemPosition position)
        {
            if (position == null) throw new ArgumentNullException(nameof(position));

            Notify(footprint, () => ItemPosition = position);
        }
    }
}