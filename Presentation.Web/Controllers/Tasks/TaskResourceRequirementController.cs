using System;
using System.Threading.Tasks;
using Bks.TrainingDevelopment.Application.Features;
using Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add;
using Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Queries.Get;
using Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Tasks
{
    [ApiController]
    [Route("training-development/tasks/{taskId:guid}/resource-requirements")]
    [FeatureGate(FeatureFlag.Task)]
    public class TaskResourceRequirementController : AbstractController
    {
        public TaskResourceRequirementController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<AddTaskResourceRequirementResponse> Add(
            [FromServices] AddTaskResourceRequirementInteractor interactor,
            Guid taskId,
            AddTaskResourceRequirementRequest request)
        {
            return await interactor.Execute(taskId, request);
        }

        [HttpGet("{requirement:guid}")]
        public async Task<GetTaskResourceRequirementResponse> Get(
            [FromServices] GetTaskResourceRequirementInteractor interactor,
            [FromRoute] Guid taskId,
            [FromRoute] Guid requirementId
            )
        {
            return await interactor.Execute(taskId, requirementId);
        }
    }
}