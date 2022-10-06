﻿using ReportCommander.Core;
using ReportCommander.Core.Interfaces;
using System.Linq.Expressions;

namespace ReportCommander.Application;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    TEntity FindById(int id);

    IEnumerable<TEntity> Find(ISpecification<TEntity> specification = null);

    void Add(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);

    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);

    void Update(TEntity entity);

    bool Contains(ISpecification<TEntity> specification = null);
    bool Contains(Expression<Func<TEntity, bool>> predicate);

    int Count(ISpecification<TEntity> specification = null);
    int Count(Expression<Func<TEntity, bool>> predicate);
}
