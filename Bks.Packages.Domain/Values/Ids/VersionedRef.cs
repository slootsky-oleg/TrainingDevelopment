using System;

namespace Bks.Packages.Domain.Values.Ids
{
    public class VersionedRef
    {
        public Guid Id { get; }
        public Guid Version { get; }
    }
}