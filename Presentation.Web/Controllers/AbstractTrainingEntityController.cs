﻿using System;
using System.Threading.Tasks;
using Bks.Training.Development.Application.TrainingDevelopment.Common.Queries.Get;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bks.Training.Development.Presentation.Web.Controllers
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