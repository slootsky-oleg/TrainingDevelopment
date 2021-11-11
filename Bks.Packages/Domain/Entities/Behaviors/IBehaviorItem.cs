using Bks.Packages.Domain.Entities.Notifications.Audit;
using Bks.Packages.Domain.Values.Ids;

namespace Bks.Packages.Domain.Entities.Behaviors
{
    public interface IBehaviorItem : INotifyChanged
    {
        GuidId Id { get; }
    }
}