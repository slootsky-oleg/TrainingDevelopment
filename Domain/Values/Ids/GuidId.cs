using System;
using System.Collections.Generic;

namespace Domain.Values.Ids
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

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return guid;
        }
    }
}