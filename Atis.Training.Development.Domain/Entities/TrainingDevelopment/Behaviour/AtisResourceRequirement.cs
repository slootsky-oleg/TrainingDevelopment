using Bks.Fox.Domain.Behaviors.ResourceRequirements;
using Bks.Fox.Domain.Values.Ids;

namespace Atis.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public class AtisResourceRequirement : ResourceRequirement
    {
        public bool IsRequired { get; }

        public AtisResourceRequirement(GuidId resourceTypeId, int? quantity)
            : base(resourceTypeId, quantity)
        {
        }
    }
}