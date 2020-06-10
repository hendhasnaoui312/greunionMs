using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Chaufferie.ChargesMS.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> condition,
           Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes);
        TEntity Get(Expression<Func<TEntity, bool>> condition,
           Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);
        TEntity Add(TEntity Entity);
        TEntity Update(TEntity Entity);
        TEntity Delete(Guid Id);

    }
}
