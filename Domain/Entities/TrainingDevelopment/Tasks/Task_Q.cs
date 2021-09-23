using System.Collections.Generic;
using System.Linq;
using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Entities.TrainingDevelopment.Containers.Resources;

namespace Domain.Entities.TrainingDevelopment.Tasks
{
    //Should we define Collective and Individual entities?
    public class Task_Q : 
        TrainingDevelopmentEntity,
        IEvaluable,
        IHasPrerequisites,
        IHasResourceRequirements,
        IHasSeats,
        IHasTargetAudience,
        IArchivable,
        IHasRelatedEntities<Task_Q>
    {
        public EvaluationOutline EvaluationOutline_Q { get; }
        public PrerequisiteContainer Prerequisites_Q { get; }
        public ResourceRequirementsContainer ResourceRequirements_Q { get; }
        public SeatContainer Seats_Q { get; }
        public TargetAudienceContainer TargetAudience { get; }
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
    }
}