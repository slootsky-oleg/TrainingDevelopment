﻿using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    //Should we define Collective and Individual entities?
    public class Task_Q: TrainingDevelopmentEntity
    {
        public IReadOnlyCollection<RelatedTask> RelatedTasks{ get; set; }
        
        public override void Archive()
        {
            throw new System.NotImplementedException();
        }

        public override void Restore()
        {
            throw new System.NotImplementedException();
        }
    }//Should we define Collective and Individual entities?
}