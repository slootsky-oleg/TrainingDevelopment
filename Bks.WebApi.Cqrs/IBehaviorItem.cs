using Bks.Fox.Entities.Domain.Notifications.Changes;
using Bks.Fox.Entities.Domain.Values.Ids;

namespace Bks.Fox.Entities.Behaviors.Domain
{
    public interface IBehaviorItem : INotifyEntityChanged
    {
        GuidId Id { get; }
    }
}