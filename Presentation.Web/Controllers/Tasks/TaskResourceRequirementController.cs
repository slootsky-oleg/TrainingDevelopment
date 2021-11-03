﻿using Bks.TrainingDevelopment.Application.Features;
using Bks.TrainingDevelopment.Application.Tasks.Commands.Create;
using Bks.TrainingDevelopment.Application.Tasks.Queries.Get;
using Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Commands;
using Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Tasks
{
    [ApiController]
    [Route("training-development/tasks")]
    [FeatureGate(FeatureFlag.Task)]
    public class TaskResourceRequirementController : AbstractTaskController<
        CreateTaskRequest, CreateEntityResponse,
        GetTaskRequest, GetTaskResponse>
    {
        public TaskResourceRequirementController(IMediator mediator) : base(mediator)
        {
        }
    }
}