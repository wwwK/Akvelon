using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/* Now, create a repository interface for the entity operations, so that we develop 
    loosely coupled Application. */

namespace Akvelon.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class//entity will be a project and task
    {
        TEntity Get(int id);

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);

        TEntity Find(Expression<Func<TEntity, bool>> predicate);

        void Update(TEntity entity);

        public void Remove(int id);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
