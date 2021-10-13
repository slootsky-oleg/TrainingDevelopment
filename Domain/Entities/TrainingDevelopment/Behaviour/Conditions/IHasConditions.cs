namespace Domain.Entities.TrainingDevelopment.Behaviour.Conditions
{
    public interface IHasConditions
    {
        public ExecutionConditionContainer Conditions_Q { get; }
    }
}