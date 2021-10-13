using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Behaviour;
using Domain.Entities.TrainingDevelopment.Behaviour.Conditions;
using Domain.Entities.TrainingDevelopment.Behaviour.Evaluation;
using Domain.Entities.TrainingDevelopment.Behaviour.Prerequisities;
using Domain.Entities.TrainingDevelopment.Behaviour.RelatedEntities;
using Domain.Entities.TrainingDevelopment.Behaviour.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.Behaviour.Seats;
using Domain.Entities.TrainingDevelopment.Behaviour.TargetAudience;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class TaskCollection : 
        TrainingDevelopmentEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasConditions,
        IHasResourceRequirements<ResourceRequirement>,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        ITrainingCollection<Task>
    {
        public IReadOnlyCollection<Task> Tasks { get; }
        public IReadOnlyCollection<TaskCollection> TaskCollections { get; }

        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ResourceRequirementsContainer<ResourceRequirement> ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience_Q { get; }
        public RelatedEntityContainer<Task> RelatedEntities_Q { get; }
        public ExecutionConditionContainer Conditions_Q { get; }


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

        public IReadOnlyCollection<Task> GetTrainingItems_Q()
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