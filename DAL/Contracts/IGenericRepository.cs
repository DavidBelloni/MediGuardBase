using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        T Add(T obj);

        void Update(T obj);

        void Delete(Guid id);

        IEnumerable<T> GetAll(EstadoVisita obj);

        T GetById(int id);
    }
}
