using Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment;
using Bks.Packages.Domain.Entities.Behaviors.ResourceRequirements;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TrainingTask : TrainingEntity<ResourceRequirement>
    {
        public TrainingTask(AuditRecord audit, Name name)
            : base(audit, name)
        {
        }

        public override void ValidateCanBeModified()
        {
        }
    }
}