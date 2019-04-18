using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication06HomeWork.Repository
{
    interface IRepository<T,ID>
    {
        void Save(T data);
        void Devete(T data);
        IEnumerable<T> FindAll();
        T FindById(ID id);
    }
}
