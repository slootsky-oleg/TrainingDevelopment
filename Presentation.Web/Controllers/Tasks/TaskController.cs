using System;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Application.Common.Entities.Commands.Create;
using Bks.TrainingDevelopment.Application.Features;
using Bks.TrainingDevelopment.Application.Tasks.Commands.Create;
using Bks.TrainingDevelopment.Application.Tasks.Queries.Get;
using Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Tasks
{
    [ApiController]
    [Route("training-development/tasks")]
    [FeatureGate(FeatureFlag.Task)]
    public class TaskController : AbstractController
    {
        public TaskController(IMediator mediator) : base(mediator)
        {
        }
        
        [HttpPost]
        public async Task<CreateEntityResponse> Create(
            [FromServices] CreateTaskInteractor interactor,
            CreateTaskRequest request)
        {
            return await interactor.Execute(request);
        }

        [HttpGet("{taskId:guid}")]
        public async Task<GetTaskResponse> Get(
            [FromServices] GetTaskInteractor interactor,
            [FromRoute] Guid taskId)
        {
            return await interactor.Execute(taskId);
        }
    }
}