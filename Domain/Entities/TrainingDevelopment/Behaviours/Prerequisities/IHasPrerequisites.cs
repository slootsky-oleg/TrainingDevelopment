namespace Domain.Entities.TrainingDevelopment.Behaviours.Prerequisities
{
    public interface IHasPrerequisites
    {
        PrerequisiteContainer Prerequisites_Q { get; }
    }
}