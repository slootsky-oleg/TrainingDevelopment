using System;
using System.Collections.Generic;

namespace Bks.Domain.Values.Ids
{
    public class UserId : ValueObject
    {
        private readonly int id;

        private UserId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            this.id = id;
        }

        public static UserId Of(int id)
        {
            return new UserId(id);
        }

        public static UserId Of(string id)
        {
            var idInt = int.Parse(id);
            return new UserId(idInt);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return id;
        }
    }
}