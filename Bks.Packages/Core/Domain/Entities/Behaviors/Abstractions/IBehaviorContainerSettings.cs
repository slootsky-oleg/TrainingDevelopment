namespace Bks.Packages.Core.Domain.Entities.Behaviors.Abstractions
{
    public interface IBehaviorContainerSettings
    {
        bool IsEnabled { get; }
        bool RequireUnique { get; }
    }
}