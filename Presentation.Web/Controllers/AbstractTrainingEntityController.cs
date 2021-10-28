using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Application.TrainingDevelopment.Common.Commands.Archive;
using Application.TrainingDevelopment.Common.Queries.Get;
using Domain.Entities.TrainingDevelopment.Behaviour;
using MediatR;

namespace Presentation.Web.Controllers
{
    public abstract class AbstractTrainingEntityController<T> : AbstractController
        where T : ITrainingEntity
    {
        protected AbstractTrainingEntityController(IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet("{id:guid}")]
        public virtual async Task<TGetEntityResponse> Get<TGetEntityResponse>(
            [FromServices] IGetTrainingEntityInteractor<T, TGetEntityResponse> interactor,
            Guid id)
        {
            return await interactor.Execute(id);
        }
        // [HttpGet("{id:guid}")]
        // public virtual async Task<TGetEntityResponse> Get<TGetEntityResponse>(
        //     [FromServices] IGetTrainingEntityInteractor<T, TGetEntityResponse> interactor,
        //     Guid id)
        // {
        //     return await interactor.Execute(id);
        // }
        
        // [HttpPost("archive")]
        // public virtual async Task Archive(
        //     [FromServices] IArchiveTrainingEntityInteractor<T> interactor,
        //     Guid id)
        // {
        //     await interactor.Execute(id);
        // }

    }
}