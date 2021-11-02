using System;
using MediatR;

namespace Atis.TrainingDevelopment.Application.Tasks.Queries.Get
{
    public class GetAtisTaskRequest : IRequest<GetAtisTaskResponse>
    {
        public Guid Id { get; set; }
    }
}