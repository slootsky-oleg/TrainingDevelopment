﻿using Bks.Practices.Ddd.Domain.Values;
using Bks.Practices.Ddd.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks
{
    public class TaskRelationCategory
    {
        public GuidId Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
    }
}