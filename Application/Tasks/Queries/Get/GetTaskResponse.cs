﻿using Bks.TrainingDevelopment.Application.Common.Entities.Queries.Get;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;

namespace Bks.TrainingDevelopment.Application.Tasks.Queries.Get
{
    public class GetTaskResponse : AbstractGetEntityResponse
    {
        public GetTaskResponse(TrainingTask entity) : base(entity)
        {
        }
    }
}