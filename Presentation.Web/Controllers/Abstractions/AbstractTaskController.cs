﻿using Bks.Packages.Cqrs;
using MediatR;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions
{
    public class AbstractTaskController<
            TCreateRequest, TCreateResponse,
            TGetRequest, TGetResponse>
        : AbstractTrainingEntityController<
            TCreateRequest, TCreateResponse,
            TGetRequest, TGetResponse>
        where TCreateRequest : IRequest<TCreateResponse>
        where TGetRequest : IRequest<TGetResponse>

    {
        public AbstractTaskController(IRequestMediator mediator) : base(mediator)
        {
        }
    }
}