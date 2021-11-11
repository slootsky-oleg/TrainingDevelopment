using Bks.Packages.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour.Versioning
{
    public interface IVersionable
    {
        public Version Version { get; }
    }
}