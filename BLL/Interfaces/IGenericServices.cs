using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGenericServices<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        bool Delete(int id);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }

}
