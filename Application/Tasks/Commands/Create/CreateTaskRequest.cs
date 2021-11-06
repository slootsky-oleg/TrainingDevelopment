﻿using Bks.TrainingDevelopment.Application.Common.Entities.Commands.Create;
using MediatR;

namespace Bks.TrainingDevelopment.Application.Tasks.Commands.Create
{
    public class CreateTaskRequest :
        AbstractCreateEntityRequest,
        IRequest<CreateEntityResponse>
    {
    }
}