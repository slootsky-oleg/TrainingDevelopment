using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Presentation.Web.Controllers
{
    [ApiController]
    public abstract class AbstractTrainingEntityController<T> : ControllerBase
    {
        [HttpGet]
        public abstract Task<T> Get(Guid id);
    }
}
