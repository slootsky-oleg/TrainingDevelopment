namespace Domain.Entities.TrainingDevelopment.BuilingBlocks.Prerequisities
{
    public interface IHasPrerequisites
    {
        PrerequisiteContainer Prerequisites_Q { get; }
    }
}