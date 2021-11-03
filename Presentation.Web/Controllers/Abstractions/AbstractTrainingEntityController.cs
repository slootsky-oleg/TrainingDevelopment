using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bks.TrainingDevelopment.Presentation.Web.Controllers.Abstractions
{
    public abstract class AbstractTrainingEntityController<
            TCreateRequest, TCreateResponse,
            TGetRequest, TGetResponse>
        : AbstractController
        where TCreateRequest : IRequest<TCreateResponse>
        where TGetRequest : IRequest<TGetResponse>
        where TGetResponse : class

    {
    protected AbstractTrainingEntityController(IMediator mediator)
        : base(mediator)
    {
    }


    [HttpPost]
    public async Task<TCreateResponse> Create(TCreateRequest request)
    {
        return await Mediator.Send(request);
    }

    [HttpGet("{id}")]
    //public async Task<TGetResponse> Get(Guid id)
    public async Task<TGetResponse> Get([FromRoute] TGetRequest request)
    {
        return await Mediator.Send(request);
    }

    // [HttpPost("archive")]
    // public virtual async Task Archive(
    //     [FromServices] IArchiveTrainingEntityInteractor<T> interactor,
    //     Guid id)
    // {
    //     await interactor.Execute(id);
    // }
    }
}