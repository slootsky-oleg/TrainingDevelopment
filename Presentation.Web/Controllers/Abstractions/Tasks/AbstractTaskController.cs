using MediatR;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions.Tasks
{
    public class AbstractTaskController<
            TCreateRequest, TCreateResponse,
            TGetRequest, TGetResponse>
        : AbstractTrainingEntityController<
            TCreateRequest, TCreateResponse,
            TGetRequest, TGetResponse>
        where TCreateRequest : IRequest<TCreateResponse>
        where TGetRequest : IRequest<TGetResponse>
        where TGetResponse : class

    {
        public AbstractTaskController(IMediator mediator) : base(mediator)
        {
        }
    }
}