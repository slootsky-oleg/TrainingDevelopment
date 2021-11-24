using Bks.Domain.Values.Ids;
using Bks.Fox.Entities.Behaviors.ResourceRequirements.Domain;

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