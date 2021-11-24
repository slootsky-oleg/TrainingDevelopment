using Bks.Practices.Ddd.Domain.Notifications.Changes;
using Bks.Practices.Ddd.Domain.Values.Ids;

namespace Bks.Fox.Entities.Behaviors.Domain
{
    public interface IBehaviorItem : INotifyEntityChanged
    {
        GuidId Id { get; }
    }
}