﻿using System;
using System.Collections.Generic;
using System.Linq;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks.Collections;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Activities
{
    public abstract class AbstractActivity<TTask, TStep, TResourceRequirement> : 
        TrainingEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasConditions,
        IHasResourceRequirements<TResourceRequirement>,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        ITrainingCollection<TTask>
        where TStep: Step
        where TTask: AbstractTask<TStep, TResourceRequirement>
        where TResourceRequirement: ResourceRequirement
    {
        public TimeSpan Duration { get; set; }
        public IReadOnlyCollection<TTask> Tasks { get; }
        public IReadOnlyCollection<AbstractTaskCollection<TTask, TStep, TResourceRequirement>> TaskCollections { get; }

        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ResourceRequirementsContainer<TResourceRequirement> ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience_Q { get; }
        public ExecutionConditionContainer Conditions_Q { get; }


        public void Activate_Q()
        {
            throw new NotImplementedException();
        }

        public void Deprecate_Q()
        {
            throw new NotImplementedException();
        }

        public void Obsolete_Q()
        {
            throw new NotImplementedException();
        }

        public void Archive_Q()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<TTask> GetTrainingItems_Q()
        {
            var tasksFromCollections = TaskCollections
                .Select(s => s.GetTrainingItems_Q())
                .SelectMany(s => s);

            return tasksFromCollections
                .Concat(Tasks)
                .ToList();
        }
    }
}