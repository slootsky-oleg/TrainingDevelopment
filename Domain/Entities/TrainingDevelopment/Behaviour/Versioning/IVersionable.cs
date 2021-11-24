using Bks.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Versioning
{
    public interface IVersionable
    {
        public Version Version { get; }
    }
}