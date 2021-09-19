using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class TaskCollection : TrainingDevelopmentCollectionEntity<Task_Q>
    {
        public IReadOnlyCollection<Task_Q> Tasks { get; set; }
        public IReadOnlyCollection<TaskCollection> TaskCollections { get; set; }

        public override IReadOnlyCollection<Task_Q> GetTrainingItems()
        {
            var tasksFromCollections = TaskCollections
                .Select(s => s.GetTrainingItems())
                .SelectMany(s => s);

            return tasksFromCollections
                .Concat(Tasks)
                .ToList();
        }
    }
}