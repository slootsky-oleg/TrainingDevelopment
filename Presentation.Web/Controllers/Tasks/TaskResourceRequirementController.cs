using Bks.TrainingDevelopment.Application.Features;
using Bks.TrainingDevelopment.Application.Tasks.Commands.Create;
using Bks.TrainingDevelopment.Application.Tasks.Queries.Get;
using Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Commands.Add;
using Bks.TrainingDevelopment.Application.Tasks.ResourceRequirements.Queries.Get;
using Bks.TrainingDevelopment.Application.TrainingDevelopment.Common.Commands;
using Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions.Behaviour;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Tasks
{
    [ApiController]
    [Route("training-development/tasks/{entityId:guid}/resource-requirements")]
    [FeatureGate(FeatureFlag.Task)]
    public class TaskResourceRequirementController : AbstractBehaviorController<
        AddTaskResourceRequirementRequest, AddTaskResourceRequirementResponse,
        GetTaskResourceRequirementRequest, GetTaskResourceRequirementResponse>
    {
        public TaskResourceRequirementController(IMediator mediator) : base(mediator)
        {
        }
    }
}