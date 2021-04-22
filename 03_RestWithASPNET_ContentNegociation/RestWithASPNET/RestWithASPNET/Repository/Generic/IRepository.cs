using RestWithASPNET.Model;
using RestWithASPNET.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T Update(T item);

        void Delete(long id);

        T FindByID(long id);

        List<T> FindAll();

        bool Exists(long id);
    }
}
