using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Application.TrainingDevelopment.Common.Commands.Archive;
using Application.TrainingDevelopment.Common.Queries.Get;
using Domain.Entities.TrainingDevelopment.Behaviour;

namespace Presentation.Web.Controllers
{
    [ApiController]
    public abstract class AbstractTrainingEntityController<T> : ControllerBase
        where T : ITrainingDevelopmentEntity
    {
        [HttpGet("{id:guid}")]
        public virtual async Task<T> Get(
            [FromServices] IGetTrainingEntityInteractor<T> interactor,
            Guid id)
        {
            return await interactor.Execute(id);
        }

        [HttpPost("archive")]
        public virtual async Task Archive(
            [FromServices] IArchiveTrainingEntityInteractor<T> interactor,
            Guid id)
        {
            await interactor.Execute(id);
        }

    }
}