using Domain.Atis.Entities.TrainingDevelopment;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Web.Controllers.Atis
{
    [Route("atis/tasks")]
    public class AtisTaskController: AbstractTrainingEntityController<AtisTask>
    {
        public AtisTaskController(IMediator mediator) : base(mediator)
        {
        }
    }
}