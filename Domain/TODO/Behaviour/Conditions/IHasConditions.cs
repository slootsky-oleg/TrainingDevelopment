namespace Bks.Fox.TrainingDevelopment.Domain.TODO.Behaviour.Conditions
{
    public interface IHasConditions
    {
        public ExecutionConditionContainer Conditions { get; }
    }
}