using Bks.TrainingDevelopment.Domain.Entities.Events;
using Bks.TrainingDevelopment.Domain.Values.Ids;

namespace Bks.TrainingDevelopment.Domain.Entities.TrainingDevelopment.Behaviour
{
    public interface IBehaviorItem : INotifyChanged
    {
        GuidId Id { get; }
    }
}