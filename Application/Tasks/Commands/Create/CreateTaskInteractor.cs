﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Bks.Packages.Domain.Values;
using Bks.Packages.Domain.Values.Ids;
using Bks.TrainingDevelopment.Application.Common.Entities.Commands.Create;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;

namespace Bks.TrainingDevelopment.Application.Tasks.Commands.Create
{
    public class CreateTaskInteractor
    {
        public async Task<CreateEntityResponse> Execute(AuditRecord audit, CreateTaskRequest request)
        {
            var name = Name.Of(request.Name);
            var externalId = ExternalId.Of(request.ExternalId);
            var description = Description.Of(request.Description);

            var task = new TrainingTask(name);
            task.SetExternalId(audit, externalId);
            task.SetName(audit, name);
            task.SetDescription(audit, description);

            return new CreateEntityResponse(task);
        }
    }
}