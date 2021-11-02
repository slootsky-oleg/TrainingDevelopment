using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers
{
    [ApiController]
    public abstract class AbstractController : ControllerBase
    {
        protected readonly IMediator mediator;

        protected AbstractController(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}