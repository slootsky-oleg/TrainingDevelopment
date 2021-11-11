using System;
using System.Collections.Generic;

namespace Bks.Packages.Domain.Values.Ids
{
    public class GuidId : ValueObject
    {
        private readonly Guid guid;

        public GuidId(Guid guid)
        {
            if (guid == Guid.Empty)
            {
                throw new ArgumentException("Guid cannot be empty", nameof(guid));
            }

            this.guid = guid;
        }

        public static GuidId Of(Guid guid)
        {
            return new GuidId(guid);
        }

        public static GuidId New()
        {
            var guid = Guid.NewGuid();
            return new GuidId(guid);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return guid;
        }

        public static implicit operator Guid(GuidId id)
        {
            return id.guid;
        }
    }
}