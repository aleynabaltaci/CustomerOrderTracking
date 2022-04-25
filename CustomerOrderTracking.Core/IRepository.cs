﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderTracking.Core
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        T Update(T entity);
        void Remove(T entity);
    }
}