using Bks.Packages.Core.Domain.Entities.Notifications.Changes;
using Bks.Packages.Core.Domain.Values.Ids;

namespace Bks.Packages.Core.Domain.Entities.Behaviors.Abstractions
{
    public interface IBehaviorItem : INotifyEntityChanged
    {
        GuidId Id { get; }
    }
}