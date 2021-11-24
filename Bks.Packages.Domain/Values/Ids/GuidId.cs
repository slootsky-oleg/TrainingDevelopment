using System;

namespace Bks.Practices.Ddd.Domain.Values.Ids
{
    public class GuidId : GuidValueObject
    {
        public GuidId(Guid guid) : base(guid)
        {
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
    }
}