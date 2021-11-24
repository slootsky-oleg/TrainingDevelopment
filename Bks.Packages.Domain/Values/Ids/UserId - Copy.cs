using System;

namespace Bks.Fox.Domain.Values.Ids
{
    public class LibraryId : GuidValueObject
    {
        public LibraryId(Guid guid) : base(guid)
        {
        }
    }
}