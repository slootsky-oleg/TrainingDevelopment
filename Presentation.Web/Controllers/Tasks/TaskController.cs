using System;
using System.Threading.Tasks;
using Bks.AspNetCore.WebApi.Controllers;
using Bks.Fox.TrainingDevelopment.Tasks.Application.Commands.Create;
using Bks.Fox.TrainingDevelopment.Tasks.Application.Queries.Get;
using Bks.Packages.Core.Application.Entities.Commands.Create;
using Bks.Packages.Core.Application.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace Bks.Fox.TrainingDevelopment.Tasks.Presentation.Web.Controllers.Tasks
{
    [ApiController]
    [Route("training-development/tasks")]
    [FeatureGate(FeatureFlag.Task)]
    public class TaskController : AbstractController
    {
        [HttpPost]
        public async Task<CreateEntityResponse> Create(
            [FromServices] CreateTaskInteractor interactor,
            CreateTaskRequest request)
        {
            var footprint = GetUserFootprint();
            return await interactor.Execute(footprint, request);
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