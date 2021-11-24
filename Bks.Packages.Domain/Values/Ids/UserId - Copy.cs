using System;

namespace Bks.Practices.Ddd.Domain.Values.Ids
{
    public class LibraryId : GuidValueObject
    {
        public LibraryId(Guid guid) : base(guid)
        {
        }
    }
}