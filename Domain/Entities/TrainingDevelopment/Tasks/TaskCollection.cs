using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.BuilingBlocks;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.Evaluation;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.Prerequisities;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.RelatedEntities;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.ResourceRequirements;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.Seats;
using Domain.Entities.TrainingDevelopment.BuilingBlocks.TargetAudience;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    public class TaskCollection : 
        TrainingDevelopmentEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasResourceRequirements,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        ITrainingCollection<Task_Q>
    {
        public IReadOnlyCollection<Task_Q> Tasks { get; }
        public IReadOnlyCollection<TaskCollection> TaskCollections { get; }

        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ResourceRequirementsContainer ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience_Q { get; }
        public RelatedEntityContainer<Task_Q> RelatedEntities_Q { get; }
        
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

        public IReadOnlyCollection<Task_Q> GetTrainingItems_Q()
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