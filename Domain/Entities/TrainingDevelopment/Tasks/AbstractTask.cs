using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks.Steps;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Tasks
{
    public abstract class AbstractTask<TStep, TResourceRequirement> : 
        TrainingEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasConditions,
        IHasResourceRequirements<TResourceRequirement>,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        IHasRelatedEntities<AbstractTask<TStep, TResourceRequirement>>
        where TResourceRequirement: ResourceRequirement
        where TStep: Step
    {
        public StepContainer<TStep> Steps { get; }
        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ExecutionConditionContainer Conditions_Q { get; }
        public ResourceRequirementsContainer<TResourceRequirement> ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience_Q { get; }
        public RelatedEntityContainer<AbstractTask<TStep, TResourceRequirement>> RelatedEntities_Q { get; }


        public void Activate_Q()
        {
            throw new System.NotImplementedException();
        }

        public void Deprecate_Q()
        {
            throw new System.NotImplementedException();
        }

        public void Obsolete_Q()
        {
            throw new System.NotImplementedException();
        }

        public void Archive_Q()
        {
            throw new System.NotImplementedException();
        }
    }
}