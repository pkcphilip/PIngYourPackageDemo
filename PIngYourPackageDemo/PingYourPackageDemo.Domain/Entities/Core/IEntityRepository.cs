﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PingYourPackageDemo.Domain.Entities;

namespace PingYourPackageDemo.Domain.Entities.Core
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> All { get; }

        IQueryable<T> GetAll { get; }

        T GetSingle(Guid key);

        IQueryable<T> FindBy(Expression<Func<T, object>> predicate);

        PaginatedList<T> Paginate<TKey>(int pageIndex, int pageSize, Expression<Func<T, TKey>> keySelector);

        PaginatedList<T> Paginate<TKey>(int pageIndex, int pageSize, Expression<Func<T, TKey>> keySelector,
            Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);

        void Save();
    }
}
