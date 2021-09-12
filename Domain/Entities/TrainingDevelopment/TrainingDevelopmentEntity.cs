using Domain.Entities.TrainingDevelopment.Containers;
using Domain.Entities.TrainingDevelopment.Containers.Resources;
using Domain.Values;
using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment
{
    //TODO: remove setters
    public abstract class TrainingDevelopmentEntity : BaseEntity
    {
        //TODO: Define Audience
        public TargetAudienceContainer TargetAudience { get; set; }

        public EvaluationOutline EvaluationOutline { get; set; }

        //TODO: Define ResourceRequirements
        public ResourceRequirementsContainer ResourceRequirements { get; set; }

        //TODO: Define CheckListContainer
        public CheckListContainer CheckList { get; set; }

        public PrerequisiteContainer Prerequisites { get; set; }
        public SeatContainer Seats { get; set; }
    }
}