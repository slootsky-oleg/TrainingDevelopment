using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Plans
{
    public class Plan : AbstractPlan<TrainingTask, Step, ResourceRequirement>
    {
    }
}