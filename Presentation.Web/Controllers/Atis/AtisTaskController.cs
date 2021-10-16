using Domain.Atis.Entities.TrainingDevelopment;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Web.Controllers.Atis
{
    [Route("atis/tasks")]
    public class AtisTaskController: AbstractTrainingEntityController<AtisTask>
    {
    }
}