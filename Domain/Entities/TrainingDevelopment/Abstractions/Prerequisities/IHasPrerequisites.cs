namespace Domain.Entities.TrainingDevelopment.Abstractions.Prerequisities
{
    public interface IHasPrerequisites
    {
        PrerequisiteContainer Prerequisites_Q { get; }
    }
}