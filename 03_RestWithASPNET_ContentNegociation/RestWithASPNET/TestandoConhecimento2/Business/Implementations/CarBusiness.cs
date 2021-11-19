using System.Collections.Generic;
using TestandoConhecimento2.Business.Interfaces;
using TestandoConhecimento2.Model.Entities;
using TestandoConhecimento2.Repository.Generic;

namespace TestandoConhecimento2.Business.Implementations
{
    public class CarBusiness : ICarBusiness
    {
        private readonly IRepository<Car> _repository;

        public CarBusiness(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public Car Create(Car item)
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

        public IList<Car> GetAll()
        {
            return _repository.GetAll();
        }

        public Car GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Car Update(Car item)
        {
            return _repository.Update(item);
        }
    }
}
