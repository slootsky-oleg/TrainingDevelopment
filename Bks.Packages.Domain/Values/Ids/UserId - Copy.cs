using System;

namespace Bks.Packages.Domain.Values.Ids
{
    public class LibraryId : GuidValueObject
    {
        public LibraryId(Guid guid) : base(guid)
        {
        }
    }
}