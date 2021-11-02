using Atis.Training.Development.Domain.Entities.TrainingDevelopment;
using Bks.Training.Development.Presentation.Web.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Atis.Training.Development.Presentation.Web.Controllers
{
    [Route("atis/tasks")]
    public class AtisTaskController: AbstractTrainingEntityController<AtisTask>
    {
        public AtisTaskController(IMediator mediator) : base(mediator)
        {
        }
    }
}