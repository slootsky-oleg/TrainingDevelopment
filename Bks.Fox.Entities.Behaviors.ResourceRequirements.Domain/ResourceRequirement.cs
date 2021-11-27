using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Channels;
using Bks.Fox.Behaviors.Domain;
using Bks.Fox.Behaviors.ResourceRequirements.Domain.Criteria;
using Bks.Fox.Domain.Entities;
using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Behaviors.ResourceRequirements.Domain
{
    public class ResourceRequirement : Entity, INotifyEntityChanged
    {
        private readonly BehaviourContainer<ResourceRequirementCriterion> criteria;

        public event EventHandler<ChangeEventArgs> Changed;

        public Name Name { get; private set; }
        public Description Description { get; private set; }

        public ResourceRequirement(Name name)
        {
            Bubble criteria change events
            
            Changed = delegate { };

            Name = name;
            criteria = new BehaviourContainer<ResourceRequirementCriterion>();
        }

        public void SetName(UserFootprint footprint, Name name)
        {
            Notify(footprint, () => Name = name);
        }

        public void SetDescription(UserFootprint footprint, Description description)
        {
            Notify(footprint, () => Description = description);
        }

        private void Notify(UserFootprint footprint, Action action)
        {
            action.Invoke();
            Changed?.Notify(this, footprint);
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