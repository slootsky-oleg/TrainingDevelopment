using System;

namespace Bks.Packages.Core.Domain.Values.Ids
{
    public class VersionedRef
    {
        public Guid Id { get; }
        public Guid Version { get; }
    }
}