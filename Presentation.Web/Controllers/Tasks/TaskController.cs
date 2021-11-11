using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Application.Commands.Create;
using Bks.Fox.TrainingDevelopment.Tasks.Application.Queries.Get;
using Bks.Packages.Application.Entities.Commands.Create;
using Bks.Packages.Application.Features;
using Bks.Packages.Presentation.Controllers;
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
            var audit = GetAuditRecord();
            return await interactor.Execute(audit, request);
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