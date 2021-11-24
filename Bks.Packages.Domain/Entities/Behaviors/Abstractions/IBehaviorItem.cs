using Bks.Packages.Domain.Entities.Notifications.Changes;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Entities.Behaviors.Abstractions
{
    public interface IBehaviorItem : INotifyEntityChanged
    {
        GuidId Id { get; }
    }
}