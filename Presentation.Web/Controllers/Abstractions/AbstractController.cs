using Bks.Packages.Cqrs;
using Microsoft.AspNetCore.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions
{
    [ApiController]
    public abstract class AbstractController : ControllerBase
    {
        protected readonly IRequestMediator Mediator;

        protected AbstractController(IRequestMediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}