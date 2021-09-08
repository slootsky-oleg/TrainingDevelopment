﻿using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Tasks;

namespace Domain.Entities.TrainingDevelopment.Activities
{
    public class Activity : TrainingDevelopmentCollectionEntity<Task>
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
    }
}