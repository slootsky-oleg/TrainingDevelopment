using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;
using Bks.Fox.Entities.Domain.Values.Ids;

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