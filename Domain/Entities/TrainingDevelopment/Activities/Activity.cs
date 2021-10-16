using Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.Tasks;
using Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Domain.Entities.TrainingDevelopment.Activities
{
    public class Activity : AbstractActivity<TrainingTask, Step, ResourceRequirement>
    {

    }
}