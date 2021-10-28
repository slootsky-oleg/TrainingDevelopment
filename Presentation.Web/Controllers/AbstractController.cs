using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Application.TrainingDevelopment.Common.Commands.Archive;
using Application.TrainingDevelopment.Common.Queries.Get;
using Domain.Entities.TrainingDevelopment.Behaviour;
using MediatR;

namespace Presentation.Web.Controllers
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