using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.Core
{
    class PostgresUnitOfWork : IUnitOfWork
    {
        private List<Repositories.IRepository<TEntity>> _inserted;
        private List<IEntity> _updated;
        private List<IEntity> _deleted;

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
