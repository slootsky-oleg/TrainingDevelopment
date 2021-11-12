using System.Collections.Generic;

namespace Bks.Packages.Core.Domain.Values.Strings
{
    public abstract class StringValueObject : ValueObject
    {
        protected readonly string value;
        protected abstract string ValueName { get; }

        protected abstract int GetMaxLength();

        protected StringValueObject(string value)
        {
            var validator = new StringValueObjectValidator(ValueName);
            validator.Validate(value, GetMaxLength());

            this.value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}