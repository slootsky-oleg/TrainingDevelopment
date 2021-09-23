using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Tasks;

namespace Domain.Entities.TrainingDevelopment.Activities
{
    public class Activity : TrainingDevelopmentEntity, ITrainingCollection<Task_Q>
    {
        public TimeSpan Duration { get; set; }
        public IReadOnlyCollection<Task_Q> Tasks { get; }
        public IReadOnlyCollection<TaskCollection> TaskCollections { get; }

        public IReadOnlyCollection<Task_Q> GetTrainingItems_Q()
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