using System;

namespace Bks.TrainingDevelopment.Domain.Values.Ids
{
    public class VersionedRef
    {
        public Guid Id { get; }
        public Guid Version { get; }
    }
}