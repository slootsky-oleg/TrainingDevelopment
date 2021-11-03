﻿using System;
using Bks.TrainingDevelopment.Application.Common.Queries.Get;
using MediatR;

namespace Atis.TrainingDevelopment.Application.Tasks.Queries.Get
{
    public class GetAtisTaskRequest : AbstractGetEntityRequest, IRequest<GetAtisTaskResponse>
    {
    }
}