using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    //Should we define Collective and Individual entities?
    public class Task_Q: TrainingDevelopmentEntity
    {
        public IReadOnlyCollection<RelatedTask> RelatedTasks{ get; set; }
    }
}