using System.Collections.Generic;
using TestandoConhecimento.Model.Entities;

namespace TestandoConhecimento.Business.Interfaces
{
    public interface IPersonBusiness
    {
        Person Create(Person item);

        Person Update(Person item);

        void Delete(int id);

        Person GetById(int id);

        List<Person> GetAll();

        bool Exists(int id);
    }
}
