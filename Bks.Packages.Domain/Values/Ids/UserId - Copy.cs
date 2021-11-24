using System;

namespace Bks.Fox.Entities.Domain.Values.Ids
{
    public class LibraryId : GuidValueObject
    {
        public LibraryId(Guid guid) : base(guid)
        {
        }
    }
}