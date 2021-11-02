﻿using System;
using MediatR;

namespace Bks.Training.Development.Application.Atis.Tasks.Queries.Get
{
    public class GetAtisTaskRequest : IRequest<GetAtisTaskResponse>
    {
        public Guid Id { get; set; }
    }
}