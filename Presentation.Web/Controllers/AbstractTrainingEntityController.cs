using MediatR;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers
{
    public abstract class AbstractTrainingEntityController<TCreateRequest> : AbstractController
    {
        protected AbstractTrainingEntityController(IMediator mediator)
            : base(mediator)
        {
        }

        // [HttpGet("{id:guid}")]
        // public async Task<TGetResponse> Get<TGetEntityResponse>(
        //     [FromServices] IGetTrainingEntityInteractor<T, TGetEntityResponse> interactor,
        //     Guid id)
        // {
        //     return await interactor.Execute(id);
        // }
        
        // [HttpPost("archive")]
        // public virtual async Task Archive(
        //     [FromServices] IArchiveTrainingEntityInteractor<T> interactor,
        //     Guid id)
        // {
        //     await interactor.Execute(id);
        // }

    }
}