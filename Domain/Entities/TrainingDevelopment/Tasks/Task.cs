using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class Task: TrainingDevelopmentEntity
    {
        public IReadOnlyCollection<Step> Steps { get; set; }
        public IReadOnlyCollection<RelatedTask> RelatedTasks{ get; set; }
    }
}