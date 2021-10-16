using System;
using System.Threading.Tasks;
using Domain.Atis.Entities.TrainingDevelopment;
using Domain.Entities.TrainingDevelopment.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Web.Controllers
{
    [Route("tasks")]
    public class TaskController: AbstractTrainingEntityController<TrainingTask>
    {
    }
}