using Bks.Packages.Domain.Values.Ids;
using Bks.TrainingDevelopment.Domain.Entities.Events;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface IBehaviorItem : INotifyChanged
    {
        GuidId Id { get; }
    }
}