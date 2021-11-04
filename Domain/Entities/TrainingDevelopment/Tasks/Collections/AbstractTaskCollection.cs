using System.Collections.Generic;
using System.Linq;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Collections
{
    public abstract class AbstractTaskCollection<TTask, TStep, TResourceRequirement> : 
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
        public IReadOnlyCollection<TTask> Tasks { get; }
        public IReadOnlyCollection<AbstractTaskCollection<TTask, TStep, TResourceRequirement>> TaskCollections { get; }

        public EvaluationOutline EvaluationOutline { get; }
        public PrerequisiteContainer Prerequisites { get; }
        public ResourceRequirementsContainer<TResourceRequirement> ResourceRequirements { get; }
        public SeatContainer Seats { get; }
        public TargetAudienceContainer TargetAudience { get; }
        public RelatedEntityContainer<TrainingTask> RelatedEntities { get; }
        public ExecutionConditionContainer Conditions { get; }

        public void Archive()
        {
            throw new System.NotImplementedException();
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