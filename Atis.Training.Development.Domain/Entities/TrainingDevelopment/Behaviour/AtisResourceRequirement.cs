using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Atis.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public class AtisResourceRequirement : ResourceRequirement
    {
        public bool IsRequired { get; }

        public AtisResourceRequirement(GuidId resourceTypeId, int? quantity) : base(resourceTypeId, quantity)
        {
        }
    }
}