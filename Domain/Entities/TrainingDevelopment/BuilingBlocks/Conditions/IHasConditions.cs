namespace Domain.Entities.TrainingDevelopment.BuilingBlocks.Conditions
{
    public interface IHasConditions
    {
        public ExecutionConditionContainer Conditions_Q { get; }
    }
}