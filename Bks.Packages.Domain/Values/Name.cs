using Bks.Fox.Entities.Domain.Values.Strings;

namespace Bks.Fox.Entities.Domain.Values
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