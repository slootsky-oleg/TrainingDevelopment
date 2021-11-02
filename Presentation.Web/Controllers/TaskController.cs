using Bks.Training.Development.Application.Features;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace Bks.Training.Development.Presentation.Web.Controllers
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