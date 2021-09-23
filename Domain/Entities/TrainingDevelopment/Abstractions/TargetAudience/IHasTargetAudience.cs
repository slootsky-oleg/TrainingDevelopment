namespace Domain.Entities.TrainingDevelopment.Abstractions.TargetAudience
{
    public interface IHasTargetAudience
    {
        TargetAudienceContainer TargetAudience { get; }
    }
}