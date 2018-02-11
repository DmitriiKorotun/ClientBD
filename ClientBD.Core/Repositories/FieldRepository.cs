using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ClientBD.Entities;

namespace ClientBD.Core.Repositories
{
    class FieldRepository : IRepository<Field>
    {
        public void Create(Field entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Field> Find(Expression<Func<Field, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Field> GetAll()
        {
            throw new NotImplementedException();
        }

        public Field GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Field entity)
        {
            throw new NotImplementedException();
        }
    }
}
