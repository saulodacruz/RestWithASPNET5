using System.Collections.Generic;
using TestandoConhecimento.Repository.Base;

namespace TestandoConhecimento.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T Update(T item);

        void Delete(int id);

        T GetById(int id);

        List<T> GetAll();

        bool Exists(int id);
    }
}
