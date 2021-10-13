﻿using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Activities;
using Domain.Entities.TrainingDevelopment.Behaviour;
using Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Domain.Entities.TrainingDevelopment.Tasks;
using Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Domain.Entities.TrainingDevelopment.Plans
{
    public abstract class AbstractTrainingPlan<TTask, TStep, TResourceRequirement> : 
        TrainingDevelopmentEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasResourceRequirements<TResourceRequirement>,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        ITrainingCollection<TTask>
        where TStep: Step
        where TTask: AbstractTask<TStep, TResourceRequirement>
        where TResourceRequirement: ResourceRequirement

    {
        public TimeSpan Duration { get; private set; }

        public IReadOnlyCollection<PlannedTraining<AbstractTrainingPlan<TTask, TStep, TResourceRequirement>>> Plans_Q { get; }
        public IReadOnlyCollection<PlannedTraining<AbstractActivity<TTask, TStep, TResourceRequirement>>> Activities_Q { get; }

        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ResourceRequirementsContainer<TResourceRequirement> ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience_Q { get; }
        
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
            var plans = Plans_Q
                .Select(p => p.Training.GetTrainingItems_Q())
                .SelectMany(p => p);

            var activities = Activities_Q
                .Select(a => a.Training.GetTrainingItems_Q())
                .SelectMany(a => a);

            return plans
                .Concat(activities)
                .ToList();
        }
    }
}