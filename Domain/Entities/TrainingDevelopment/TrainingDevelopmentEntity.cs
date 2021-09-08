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
        public TargetAudienceContainer AudienceContainer { get; set; }

        public EvaluationOutline EvaluationOutline { get; set; }

        //TODO: Define ResourceRequirements
        public IResourceRequirementsEnvelop ResourceRequirementsEnvelop { get; set; }
    }
}