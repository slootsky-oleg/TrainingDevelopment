using System.Collections.Generic;
using System.Linq;
using Bks.Fox.Behaviors.Domain;
using Bks.Fox.Behaviors.ResourceRequirements.Domain.Criteria;
using Bks.Fox.Domain.Values;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Behaviors.ResourceRequirements.Domain
{
    public class ResourceRequirement : BehaviourEntity
    {
        private readonly BehaviourContainer<ResourceRequirementCriterion> criteria;

        public Name Name { get; private set; }
        public Description Description { get; private set; }
        public IReadOnlyCollection<ResourceRequirementCriterion> Criteria => criteria.ToList();

        public ResourceRequirement(Name name)
        {
            Name = name;
            criteria = new BehaviourContainer<ResourceRequirementCriterion>();
            criteria.Changed += ChangeHandler;
        }

        public void SetName(UserFootprint footprint, Name name)
        {
            Notify(footprint, () => Name = name);
        }

        public void SetDescription(UserFootprint footprint, Description description)
        {
            Notify(footprint, () => Description = description);
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