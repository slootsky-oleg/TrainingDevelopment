using Bks.Fox.Entities.Domain.Values.Strings;

namespace Bks.Fox.Entities.Domain.Values.Ids
{
    public class ExternalId : StringValueObject
    {
        protected override string ValueName => GetType().Name;
        protected override int GetMaxLength() => 100;

        private ExternalId(string value)
            : base(value)
        {
        }

        public static ExternalId Of(string id)
        {
            return string.IsNullOrWhiteSpace(id)
                ? null
                : new ExternalId(id);
        }

        public static implicit operator string(ExternalId id)
        {
            return id?.value;
        }
    }
}