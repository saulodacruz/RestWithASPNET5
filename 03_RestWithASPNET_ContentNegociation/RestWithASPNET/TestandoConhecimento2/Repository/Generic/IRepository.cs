using System.Collections.Generic;
using TestandoConhecimento2.Repository.Base;

namespace TestandoConhecimento2.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T Update(T item);

        void Delete(int id);

        T GetById(int id);

        IList<T> GetAll();

        bool Exists(int id);
    }
}
