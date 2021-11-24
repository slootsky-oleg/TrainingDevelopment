﻿using System;
using System.Threading.Tasks;

namespace Bks.Domain.Repositories
{
    public interface IEntityRepository<T>
    {
        Task<T> GetAsync(Guid id);
        // Task<IReadOnlyCollection<T>> BatchGetAsync(Guid id);
        // void Add(T entity);
    }
}