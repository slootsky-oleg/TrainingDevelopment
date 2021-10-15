using System;
using System.Threading.Tasks;
using Domain.Atis.Entities.TrainingDevelopment;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Web.Controllers
{
    [Route("atis/tasks")]
    public class AtisTaskController: AbstractTrainingEntityController<AtisTask>
    {
    }
}