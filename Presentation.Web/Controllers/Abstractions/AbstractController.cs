using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions
{
    [ApiController]
    public abstract class AbstractController : ControllerBase
    {
        protected readonly IMediator Mediator;

        protected AbstractController(IMediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}