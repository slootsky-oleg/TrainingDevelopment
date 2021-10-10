using Domain.Values.Ids;

namespace Domain.Entities.TrainingDevelopment.BuilingBlocks.Versioning
{
    public interface IVersioned
    {
        public Version Version_Q { get; }
    }
}