﻿using System;
using System.Threading.Tasks;
using Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Commands.Add;
using Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Queries.Get;
using Bks.Fox.TrainingDevelopment.Tasks.Presentation.Web.Controllers.Abstractions;
using Bks.Packages.Application.Features;
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
        public async Task<AddTaskResourceRequirementResponse> Add(
            [FromServices] AddTaskResourceRequirementInteractor interactor,
            Guid taskId,
            AddTaskResourceRequirementRequest request)
        {
            var audit = GetAuditRecord();
            return await interactor.Execute(audit, taskId, request);
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