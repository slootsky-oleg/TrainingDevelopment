using Atis.Training.Development.Domain.Entities.TrainingDevelopment;
using Bks.TrainingDevelopment.Presentation.Web.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Atis.TrainingDevelopment.Presentation.Web.Controllers
{
    [Route("atis/tasks")]
    public class AtisTaskController: AbstractTrainingEntityController<AtisTask>
    {
        public AtisTaskController(IMediator mediator) : base(mediator)
        {
        }
    }
}