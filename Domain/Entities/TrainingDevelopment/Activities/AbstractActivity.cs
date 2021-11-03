using System;
using System.Collections.Generic;
using System.Linq;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Collections;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Activities
{
    public abstract class AbstractActivity<TTask, TStep, TResourceRequirement> : 
        TrainingEntity,
        IHasEvaluationCriteria,
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

        public EvaluationOutline EvaluationOutline { get; }
        public PrerequisiteContainer Prerequisites { get; }
        public ResourceRequirementsContainer<TResourceRequirement> ResourceRequirements { get; }
        public SeatContainer Seats { get; }
        public TargetAudienceContainer TargetAudience { get; }
        public ExecutionConditionContainer Conditions { get; }


        public void Activate()
        {
            throw new NotImplementedException();
        }

        public void Deprecate()
        {
            throw new NotImplementedException();
        }

        public void Obsolete()
        {
            throw new NotImplementedException();
        }

        public void Archive()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<TTask> GetTrainingItems()
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