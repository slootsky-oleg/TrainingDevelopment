using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Bks.Domain.Values
{
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

        [ExcludeFromCodeCoverage]
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            var valueObject = (ValueObject)obj;

            var equalityComponents = valueObject.GetEqualityComponents();
            return GetEqualityComponents().SequenceEqual(equalityComponents);
        }

        [ExcludeFromCodeCoverage]
        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + (obj?.GetHashCode() ?? 0);
                    }
                });
        }

        [ExcludeFromCodeCoverage]
        public static bool operator ==(ValueObject a, ValueObject b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        [ExcludeFromCodeCoverage]
        public static bool operator !=(ValueObject a, ValueObject b)
        {
            return !(a == b);
        }
    }
}