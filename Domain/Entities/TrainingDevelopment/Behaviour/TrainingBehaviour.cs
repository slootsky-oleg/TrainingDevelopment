﻿using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public abstract class TrainingBehaviour : ITrainingBehaviour
    {
        public GuidId Id { get; }
        public TrainingEntity Owner { get; }
    }
}