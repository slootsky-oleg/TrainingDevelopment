using System;
using System.Collections.Generic;
using System.Linq;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Activities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Plans
{
    public abstract class AbstractPlan<TTask, TStep, TResourceRequirement> :
        TrainingEntity,
        IHasEvaluationCriteria,
        IHasPrerequisites,
        IHasResourceRequirements<TResourceRequirement>,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        ITrainingCollection<TTask>
        where TStep : Step
        where TTask : AbstractTask<TStep, TResourceRequirement>
        where TResourceRequirement : ResourceRequirement

    {
        public TimeSpan Duration { get; private set; }

        public IReadOnlyCollection<PlannedTraining<AbstractPlan<TTask, TStep, TResourceRequirement>>> Plans { get; }

        public IReadOnlyCollection<PlannedTraining<AbstractActivity<TTask, TStep, TResourceRequirement>>> Activities
        {
            get;
        }

        public EvaluationOutline EvaluationOutline { get; }
        public PrerequisiteContainer Prerequisites { get; }
        public ResourceRequirementsContainer<TResourceRequirement> ResourceRequirements { get; }
        public SeatContainer Seats { get; }
        public TargetAudienceContainer TargetAudience { get; }

        public void Archive()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<TTask> GetTrainingItems()
        {
            var plans = Plans
                .Select(p => p.Training.GetTrainingItems())
                .SelectMany(p => p);

            var activities = Activities
                .Select(a => a.Training.GetTrainingItems())
                .SelectMany(a => a);

            return plans
                .Concat(activities)
                .ToList();
        }
    }
}