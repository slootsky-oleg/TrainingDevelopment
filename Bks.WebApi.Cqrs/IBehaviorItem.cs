using Bks.Fox.Domain.Notifications.Changes;
using Bks.Fox.Domain.Values.Ids;

namespace Bks.Fox.Domain.Behaviors
{
    public interface IBehaviorItem : INotifyEntityChanged
    {
        GuidId Id { get; }
    }
}