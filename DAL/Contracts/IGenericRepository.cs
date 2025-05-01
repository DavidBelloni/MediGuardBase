using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        T Add(T obj);

        void Update(T obj);

        void Delete(Guid id);

        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}
