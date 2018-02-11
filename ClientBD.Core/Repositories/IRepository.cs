using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.Core.Repositories
{
    public interface IUnitOfWork
    {
        void MarkDirty(object entity);
        void MarkNew(object entity);
        void MarkDeleted(object entity);
        void Commit();
        void Rollback();
        //FOR TEST
        void TEST();
    }

    public interface IRepository<TEntity> where TEntity: class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
      //  IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
