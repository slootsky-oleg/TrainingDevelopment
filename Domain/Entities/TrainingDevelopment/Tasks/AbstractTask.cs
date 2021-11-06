using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Tasks
{
    public abstract class AbstractTask<TStep, TResourceRequirement> :
        TrainingEntity,
        IHasEvaluationCriteria,
        IHasPrerequisites,
        IHasConditions,
        IHasResourceRequirements<TResourceRequirement>,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        IHasRelatedEntities<AbstractTask<TStep, TResourceRequirement>>
        where TResourceRequirement : ResourceRequirement //TODO: interface that is used by activities/events/
        where TStep : Step
    {
        public StepContainer<TStep> Steps { get; }
        public EvaluationOutline EvaluationOutline { get; }
        public PrerequisiteContainer Prerequisites { get; }
        public ExecutionConditionContainer Conditions { get; }
        public ResourceRequirementsContainer<TResourceRequirement> ResourceRequirements { get; }
        public SeatContainer Seats { get; }
        public TargetAudienceContainer TargetAudience { get; }
        public RelatedEntityContainer<AbstractTask<TStep, TResourceRequirement>> RelatedEntities { get; }

        public void Archive()
        {
            throw new System.NotImplementedException();
        }
    }
}