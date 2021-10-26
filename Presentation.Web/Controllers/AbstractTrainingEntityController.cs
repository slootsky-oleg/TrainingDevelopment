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
        where T : ITrainingEntity
    {
        [HttpGet]
        public virtual void Home()
        {

        }

        // [HttpGet("{id:guid}")]
        // public virtual async Task<TGetEntityResponse> Get<TGetEntityResponse>(
        //     [FromServices] IGetTrainingEntityInteractor<T, TGetEntityResponse> interactor,
        //     Guid id)
        // {
        //     return await interactor.Execute(id);
        // }
        //
        // [HttpPost("archive")]
        // public virtual async Task Archive(
        //     [FromServices] IArchiveTrainingEntityInteractor<T> interactor,
        //     Guid id)
        // {
        //     await interactor.Execute(id);
        // }

    }
}