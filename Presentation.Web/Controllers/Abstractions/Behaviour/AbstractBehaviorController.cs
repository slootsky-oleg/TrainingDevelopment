using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions.Behaviour
{
    public abstract class AbstractBehaviorController<
            TAddRequest, TAddResponse,
            TGetRequest, TGetResponse>
        : AbstractController
        where TAddRequest : IRequest<TAddResponse>
        where TGetRequest : IRequest<TGetResponse>
        where TGetResponse : class

    {
        protected AbstractBehaviorController(IMediator mediator)
            : base(mediator)
        {
        }


        [HttpPost]
        public async Task<TAddResponse> Create(TAddRequest request)
        {
            return await Mediator.Send(request);
        }

        [HttpGet("{behaviorId}")]
        public async Task<TGetResponse> Get([FromRoute] TGetRequest request)
        {
            return await Mediator.Send(request);
        }
    }
}