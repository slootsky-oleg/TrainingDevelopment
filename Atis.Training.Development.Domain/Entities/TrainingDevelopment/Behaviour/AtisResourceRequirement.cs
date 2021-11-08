using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Values.Ids;

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