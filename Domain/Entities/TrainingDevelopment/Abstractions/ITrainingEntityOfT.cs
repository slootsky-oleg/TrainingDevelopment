﻿using Bks.Packages.Core.Domain.Entities.Behaviors.ResourceRequirements;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Abstractions
{
    public interface ITrainingEntity<TResourceRequirement> : 
        ITrainingEntity,
        IHasResourceRequirements<TResourceRequirement>
        where TResourceRequirement : ResourceRequirement
    {
    }
}