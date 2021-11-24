using Bks.Domain.Notifications.Changes;
using Bks.Domain.Values.Ids;

namespace Bks.Fox.Entities.Behaviors.Domain
{
    public interface IBehaviorItem : INotifyEntityChanged
    {
        GuidId Id { get; }
    }
}