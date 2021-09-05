using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class TaskCollection : TrainingDevelopmentCollectionEntity<Task>
    {
        public IReadOnlyCollection<Task> Tasks { get; set; }
        public IReadOnlyCollection<TaskCollection> TaskCollections { get; set; }

        public override IReadOnlyCollection<Task> GetItems()
        {
            var tasksFromCollections = TaskCollections
                .Select(s => s.GetItems())
                .SelectMany(s => s);

            return tasksFromCollections
                .Concat(Tasks)
                .ToList();
        }
    }
}