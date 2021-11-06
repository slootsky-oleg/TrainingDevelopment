namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Conditions
{
    public interface IHasConditions
    {
        public ExecutionConditionContainer Conditions { get; }
    }
}