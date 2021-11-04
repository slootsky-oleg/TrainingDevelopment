using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions.Behaviour
{
    public abstract class AbstractEntityResourceRequirementController<
            TCreateRequest, TCreateResponse,
            TGetRequest, TGetResponse>
        : AbstractController
        where TCreateRequest : IRequest<TCreateResponse>
        where TGetRequest : IRequest<TGetResponse>
        where TGetResponse : class

    {
        protected AbstractEntityResourceRequirementController(IMediator mediator)
            : base(mediator)
        {
        }


        [HttpPost]
        public async Task<TCreateResponse> Create(TCreateRequest request)
        {
            return await Mediator.Send(request);
        }

        [HttpGet("{requirementId}")]
        public async Task<TGetResponse> Get([FromRoute] TGetRequest request)
        {
            return await Mediator.Send(request);
        }
    }
}