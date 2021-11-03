using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Versioning
{
    public interface IVersioned
    {
        public Version Version { get; }
    }
}