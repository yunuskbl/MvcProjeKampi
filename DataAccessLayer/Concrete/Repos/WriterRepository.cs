using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repos
{
    public class WriterRepository : IWriter
    {

        Context c = new Context();
        DbSet<Writer> _object;

        public Writer Get(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(Writer p)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}
