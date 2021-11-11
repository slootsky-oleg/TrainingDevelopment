using Bks.Packages.Domain.Values.Strings;

namespace Bks.Packages.Domain.Values
{
    public class Name : StringValueObject
    {
        protected override string ValueName => GetType().Name;
        protected override int GetMaxLength() => 100;

        private Name(string value) : base(value)
        {
        }

        public static Name Of(string name)
        {
            return new Name(name);
        }

        public static implicit operator string(Name name)
        {
            return name.value;
        }
    }
}