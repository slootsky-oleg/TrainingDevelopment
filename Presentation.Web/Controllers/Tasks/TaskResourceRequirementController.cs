using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Commands.Add;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.Common;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.Get;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.GetAll;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Fox.TrainingDevelopment.Tasks.Presentation.Web.Features;
using Bks.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace Bks.Fox.TrainingDevelopment.Tasks.Presentation.Web.Controllers.Tasks
{
    [ApiController]
    [Route("training-development/tasks/{taskId:guid}/resource-requirements")]
    [FeatureGate(FeatureFlag.Task)]
    public class TaskResourceRequirementController : AbstractController
    {
        [HttpPost]
        public async Task<AddResourceRequirementResponse> Add(
            [FromServices] AddResourceRequirementInteractor<TrainingTask> interactor,
            [FromRoute] [Required] Guid taskId,
            AddResourceRequirementRequest request)
        {
            var footprint = GetUserFootprint();
            return await interactor.Execute(footprint, taskId, request);
        }

        [HttpGet]
        public async Task<IList<GetResourceRequirementResponse>> GetAll(
            [FromServices] GetAllResourceRequirementsInteractor<TrainingTask> interactor,
            [FromRoute] [Required] Guid taskId)
        {
            return await interactor.Execute(taskId);
        }

        [HttpGet("{requirement:guid}")]
        public async Task<GetResourceRequirementResponse> Get(
            [FromServices] GetResourceRequirementInteractor<TrainingTask> interactor,
            [FromRoute] Guid taskId,
            [FromRoute] Guid requirementId)
        {
            return await interactor.Execute(taskId, requirementId);
        }
    }
}