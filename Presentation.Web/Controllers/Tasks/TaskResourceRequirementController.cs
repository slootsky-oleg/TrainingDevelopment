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
        public async Task<AddTaskResourceRequirementResponse> Add(AddTaskResourceRequirementRequest request)
        {
            return await Mediator.Send(request);
        }

        [HttpGet("{requirement:guid}")]
        public async Task<GetTaskResourceRequirementResponse> Get([FromRoute] GetTaskResourceRequirementRequest request)
        {
            return await Mediator.Send(request);
        }
    }
}