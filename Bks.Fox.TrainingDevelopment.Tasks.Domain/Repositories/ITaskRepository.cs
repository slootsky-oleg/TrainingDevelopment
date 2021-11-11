﻿using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Packages.Domain.Repositories;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories
{
    public interface ITaskRepository : IEntityRepository<TrainingTask>
    {
        
    }
}