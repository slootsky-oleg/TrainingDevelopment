using System;

namespace Bks.Packages.Domain.Values.Ids
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