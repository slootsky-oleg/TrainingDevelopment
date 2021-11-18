﻿using Bks.Packages.Core.Domain.Entities;
using Bks.Packages.Core.Domain.Values;

namespace Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities
{
    public class TaskType : AggregateRoot
    {
        public TaskType(UserFootprint footprint, Name name) : base(footprint, name)
        {
        }

        public TaskSettings Settings { get; private set; }

        protected override void ValidateCanBeModified()
        {
            //validate is archived, etc.
        }
    }
}