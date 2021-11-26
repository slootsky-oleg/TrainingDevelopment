using Bks.Fox.Domain.Values;
using System;
using System.Threading.Channels;

namespace Bks.Fox.Domain.Notifications.Changes
{
    public static class EntityChangedEventExtension
    {
        public static void Notify(this EventHandler<ChangeEventArgs> handler, object sender, UserFootprint footprint)
        {
            var @event = new ChangeEventArgs(footprint);
            handler?.Invoke(sender, @event);
        }
    }
}