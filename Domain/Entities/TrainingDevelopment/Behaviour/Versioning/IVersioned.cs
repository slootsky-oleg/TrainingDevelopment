using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Behaviour.Versioning
{
    public interface IVersioned
    {
        public Version Version_Q { get; }
    }
}