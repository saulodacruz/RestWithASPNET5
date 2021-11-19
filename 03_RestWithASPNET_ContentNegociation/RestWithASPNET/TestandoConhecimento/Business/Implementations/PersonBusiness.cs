using System.Collections.Generic;
using TestandoConhecimento.Business.Interfaces;
using TestandoConhecimento.Model.Entities;
using TestandoConhecimento.Repository.Generic;

namespace TestandoConhecimento.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        public PersonBusiness(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public Person Create(Person item)
        {
            return _repository.Create(item);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public bool Exists(int id)
        {
            return _repository.Exists(id);
        }

        public List<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public Person GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Person Update(Person item)
        {
            return _repository.Update(item);
        }
    }
}
