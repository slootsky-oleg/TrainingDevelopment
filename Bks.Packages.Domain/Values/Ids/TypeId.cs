using System;

namespace Bks.Practices.Ddd.Domain.Values.Ids
{
    public class TypeId : GuidValueObject
    {
        public TypeId(Guid guid) : base(guid)
        {
        }

        public static TypeId Of(Guid guid)
        {
            return new TypeId(guid);
        }
    }
}