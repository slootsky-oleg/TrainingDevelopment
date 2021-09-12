using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class TaskCollection : TrainingDevelopmentCollectionEntity<Task>
    {
        public IReadOnlyCollection<Task> Tasks { get; set; }
        public IReadOnlyCollection<TaskCollection> TaskCollections { get; set; }

        public override IReadOnlyCollection<Task> GetTrainingItems()
        {
            var tasksFromCollections = TaskCollections
                .Select(s => s.GetTrainingItems())
                .SelectMany(s => s);

            return tasksFromCollections
                .Concat(Tasks)
                .ToList();
        }

        public override void Archive()
        {
            throw new System.NotImplementedException();
        }

        public override void Restore()
        {
            throw new System.NotImplementedException();
        }
    }
}