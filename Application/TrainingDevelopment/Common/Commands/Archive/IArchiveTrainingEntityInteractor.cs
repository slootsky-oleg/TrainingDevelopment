﻿using System;
using System.Threading.Tasks;
using Domain.Entities.TrainingDevelopment.Behaviour;

namespace Application.TrainingDevelopment.Common.Commands.Archive
{
    public interface IArchiveTrainingEntityInteractor<T>
        where T: ITrainingEntity
    {
        Task Execute(Guid id);
    }
}