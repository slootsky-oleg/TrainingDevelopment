using System;
using Bks.TrainingDevelopment.Domain.Values.Strings;

namespace Bks.TrainingDevelopment.Domain.Values
{
    public class Description : StringValueObject
    {
        protected override string ValueName => GetType().Name;
        protected override int GetMaxLength() => Int32.MaxValue;

        private Description(string value) : base(value)
        {
        }

        public static Description Of(string name)
        {
            return string.IsNullOrWhiteSpace(name)
                ? null
                : new Description(name);
        }

        public static implicit operator string(Description description)
        {
            return description?.value;
        }
    }
}