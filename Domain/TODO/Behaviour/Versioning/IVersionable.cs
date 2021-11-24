using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Domain.TrainingDevelopment.TODO.Behaviour.Versioning
{
    public interface IVersionable
    {
        public Version Version { get; }
    }
}