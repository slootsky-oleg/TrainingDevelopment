using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements.Settings;
using Bks.TrainingDevelopment.Domain.Values;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements
{
    public class ResourceRequirementContainer<TRequirement> : IResourceRequirementContainer<TRequirement>
        where TRequirement : ResourceRequirement
    {
        private readonly List<TRequirement> requirements;

        public AggregationStrategy Strategy { get; }
        public IResourceRequirementSettings Settings { get; }

        public ResourceRequirementContainer(
            AggregationStrategy strategy,
            IResourceRequirementSettings settings)
        {
            requirements = new List<TRequirement>();

            Strategy = strategy;
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public IReadOnlyCollection<TRequirement> GetAll() => requirements.ToList();

        public void Add(TRequirement requirement)
        {
            //validate uniqueness
            requirements.Add(requirement);
        }

        public void Remove(TRequirement requirement)
        {
            if (!requirements.Remove(requirement))
            {
                throw new Exception("Not found");
            }
        }

        //TODO: Primary and alternative requirements
    }
}