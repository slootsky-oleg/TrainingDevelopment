using Microsoft.AspNetCore.Mvc;
using System;

namespace Presentation.Web.Controllers
{
    [ApiController]
    [Route("training-development/{entity}")]
    public class EntityController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string entity, Guid id)
        {
            //var interactor = interactorResolver.Resolve(entity, "Get");
            //return interactor.Execute(id);
            return null;
        }

        [HttpPost("{id:guid}/archive")]
        public IActionResult Archive()
        {
            //var interactor = interactorResolver.Resolve(entity, "Archive");
            //return interactor.Execute();
            return null;
        }
    }
}
