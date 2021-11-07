using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements.Settings;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirementContainer<TRequirement>
        where TRequirement : ResourceRequirement
    {
        private readonly Entity owner;
        private readonly List<TRequirement> ownRequirements;

        public AggregationStrategy Strategy { get; }
        public IResourceRequirementSettings Settings { get; }

        public IReadOnlyCollection<TRequirement> OwnRequirements => ownRequirements.ToList();

        public ResourceRequirementContainer(Entity owner, AggregationStrategy strategy, IResourceRequirementSettings settings)
        {
            this.owner = owner ?? throw new ArgumentNullException(nameof(owner));
            this.ownRequirements = new List<TRequirement>();

            Strategy = strategy;
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }
        
        public IReadOnlyCollection<TRequirement> GetAll()
        {
            //TODO: Implement collecting bottom-up and combined requirements
            throw new System.NotImplementedException();
        }

        public void Add(TRequirement requirement)
        {
            ValidateCanBeModified();

            if (Strategy == AggregationStrategy.BottomUp)
            {
                throw new NotSupportedException("");
            }

            ownRequirements.Add(requirement);
        }

        private void ValidateCanBeModified()
        {
            //check container rules;

            owner.ValidateCanBeModified();
        }


        //TODO: Primary and alternative requirements
    }
}