using RestWithASPNET.Data.Converter.Implementations;
using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;
using RestWithASPNET.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASPNET.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusiness(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return  _converter.Parse(_repository.FindAll());
        }

        public PersonVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public PersonVO Create(PersonVO person)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(person)));
        }

        public PersonVO Update(PersonVO person)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(person)));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }        
    }
}
