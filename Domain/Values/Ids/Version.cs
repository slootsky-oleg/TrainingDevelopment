using System;
using System.Collections.Generic;

namespace Bks.TrainingDevelopment.Domain.Values.Ids
{
    public class Version : ValueObject
    {
        private readonly long value;

        public Version(long version)
        {
            if (version < 1)
            {
                throw new ArgumentException("Version must be a positive number.", nameof(version));
            }
            
            this.value = version;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}