﻿using Domain.Entities.TrainingDevelopment.Behaviour;

namespace Domain.Entities.TrainingDevelopment.Plans
{
    public class PlannedTraining<T> where T: ITrainingDevelopmentEntity
    {
        public T Training { get; set; }
        public Offset Offset { get; set; }
        
        //TODO: define other PlannedTraining settings: first day of... etc.
    }
}