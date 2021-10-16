using Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.Tasks;
using Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Domain.Entities.TrainingDevelopment.Plans
{
    public class TrainingPlan : AbstractTrainingPlan<TrainingTask, Step, ResourceRequirement>
    {

    }
}