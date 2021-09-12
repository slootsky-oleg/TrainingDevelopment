using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Tasks;

namespace Domain.Entities.TrainingDevelopment.Activities
{
    public class Activity : TrainingDevelopmentCollectionEntity<Task>
    {
        public TimeSpan Duration { get; set; }
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
            throw new NotImplementedException();
        }

        public override void Restore()
        {
            throw new NotImplementedException();
        }
    }
}