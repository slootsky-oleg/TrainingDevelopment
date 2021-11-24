using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.TrainingDevelopment.Domain.TODO.Behaviour.Versioning
{
    public interface IVersionable
    {
        public Version Version { get; }
    }
}