using System;
using Bks.Fox.Domain.Entities;
using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Behaviors.ResourceRequirements.Domain.Criteria
{
    public class ResourceRequirementCriterion: Entity, INotifyEntityChanged
    {
        public event EventHandler<ChangeEventArgs> Changed;

        //TODO: Implement ordered collection
        public ItemPosition ItemPosition { get; private set; }
        public GuidId ResourceTypeId { get; private set; }
        public int? Quantity { get; private set; }

        //expressions: fieldA ==|<... value

        public void SetResourceTypeId(UserFootprint footprint, GuidId id)
        {
            Notify(footprint, () => ResourceTypeId = id);
        }
        
        public void SetQuantity(UserFootprint footprint, int? quantity)
        {
            Notify(footprint, () => Quantity = quantity);
        }

        private void Notify(UserFootprint footprint, Action action)
        {
            action.Invoke();
            Changed?.Notify(this, footprint);
        }
    }
}