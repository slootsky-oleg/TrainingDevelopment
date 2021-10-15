﻿using System;
using System.Threading.Tasks;
using Domain.Entities.TrainingDevelopment.Behaviour;

namespace Application.TrainingDevelopment.Common.Commands.Archive
{
    public interface IArchiveTrainingDevelopmentEntityInteractor<T>
        where T: ITrainingDevelopmentEntity
    {
        Task Execute(Guid id);
    }
}