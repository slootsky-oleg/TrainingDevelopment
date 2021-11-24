using System;

namespace Bks.Domain.Values.Ids
{
    public class LibraryId : GuidValueObject
    {
        public LibraryId(Guid guid) : base(guid)
        {
        }
    }
}