using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Entities.TrainingDevelopment.Containers.Resources;

namespace Domain.Entities.TrainingDevelopment
{
    public abstract class TrainingDevelopmentEntity : BaseEntity_Q
    {
        public TargetAudienceContainer TargetAudience { get; set; }

        public EvaluationOutline EvaluationOutline { get; set; }

        public CheckListContainer CheckList { get; set; }

        public SeatContainer Seats_Q { get; set; }

        //TODO: Add Derived qualifications

        public void AddResourceRequirement(ResourceRequirement requirement)
        {
            //TODO: Move to Application layer. Interactors, etc.
            //Expected signature: Validate(EntityType, feature). Throws NotSupportedException
            //featureFlagSettings.Validate(this.GetType(), nameof(ResourceRequirements));
        }
    }
}