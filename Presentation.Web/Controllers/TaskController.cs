using System;
using System.Threading.Tasks;
using Application.Features;
using Domain.Atis.Entities.TrainingDevelopment;
using Domain.Entities.TrainingDevelopment.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace Presentation.Web.Controllers
{
    [Route("training-development/tasks")]
    [FeatureGate(FeatureFlag.Task)] 
    public class TaskController: AbstractTrainingEntityController<TrainingTask>
    {
        public TaskController(IMediator mediator) : base(mediator)
        {
        }
    }
}