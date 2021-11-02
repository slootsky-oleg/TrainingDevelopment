using Bks.TrainingDevelopment.Application.Features;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers
{
    [ApiController]
    [Route("training-development/tasks")]
    [FeatureGate(FeatureFlag.Task)] 
    public class TaskController: AbstractTrainingEntityController<TrainingTask>
    {
        public TaskController(IMediator mediator) : base(mediator)
        {
        }
    }
}