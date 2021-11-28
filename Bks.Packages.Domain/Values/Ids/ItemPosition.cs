using System;
using System.Collections.Generic;

namespace Bks.Fox.Domain.Values.Ids
{
    public class ItemPosition : ValueObject
    {
        private readonly int position;

        private ItemPosition(int position)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(position));
            }

            this.position = position;
        }

        public static ItemPosition Of(int id)
        {
            return new ItemPosition(id);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return position;
        }
    }
}