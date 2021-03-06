using Api.Domain.Contracts.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Api.Cqrs.Template.Core.Contract.Repository
{
    public interface IQueryService<TEntity> where TEntity : IDomainEntity
    {
        TEntity FindById(Guid id);

        TEntity Find(Expression<Func<TEntity, bool>> expression);

        IEnumerable<TEntity> All();

        IEnumerable<TEntity> FindList(Expression<Func<TEntity, bool>> expression);
    }
}