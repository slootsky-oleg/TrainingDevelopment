using Bks.Training.Development.Domain.Values.Ids;

namespace Bks.Training.Development.Domain.Entities.TrainingDevelopment.Behaviour.Versioning
{
    public interface IVersioned
    {
        public Version Version_Q { get; }
    }
}