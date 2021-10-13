using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.Behaviours.Versioning
{
    public interface IVersioned
    {
        public Version Version_Q { get; }
    }
}