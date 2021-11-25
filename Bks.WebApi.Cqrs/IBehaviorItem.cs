using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Behaviors.Domain
{
    public interface IBehaviorItem : INotifyEntityChanged
    {
        GuidId Id { get; }
    }
}