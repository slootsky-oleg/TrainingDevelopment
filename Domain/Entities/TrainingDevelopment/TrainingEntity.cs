using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Content;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.CustomFields;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;
using Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Versioning;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment
{
    public abstract class TrainingEntity<TResourceRequirement> : 
        Entity,
        ITrainingEntity,
        IHasCustomFields, 
        IHasContent, 
        IVersionable,
        IHasEvaluationCriteria,
        IHasPrerequisites,
        IHasConditions,
        IHasResourceRequirements<TResourceRequirement>,
        IHasTargetAudience,
        IArchivable
        where TResourceRequirement : ResourceRequirement //TODO: interface that is used by activities/events/
    {
        public Version Version { get; }
        public CustomFieldContainer CustomFields { get; }
        public ContentContainer Content { get; }

        public EvaluationOutline EvaluationOutline { get; }
        public PrerequisiteContainer Prerequisites { get; }
        public ExecutionConditionContainer Conditions { get; }
        public ResourceRequirementsContainer<TResourceRequirement> ResourceRequirements { get; }
        public TargetAudienceContainer TargetAudience { get; }

        public void Archive()
        {
            throw new System.NotImplementedException();
        }
    }
}