using System;
using System.Collections.Generic;

namespace Bks.Fox.Entities.Domain.Values.Ids
{
    public abstract class GuidValueObject : ValueObject
    {
        private readonly Guid guid;

        protected GuidValueObject(Guid guid)
        {
            if (guid == Guid.Empty)
            {
                throw new ArgumentException("Guid cannot be empty", nameof(guid));
            }

            this.guid = guid;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return guid;
        }

        public static implicit operator Guid(GuidValueObject id)
        {
            return id.guid;
        }
    }
}