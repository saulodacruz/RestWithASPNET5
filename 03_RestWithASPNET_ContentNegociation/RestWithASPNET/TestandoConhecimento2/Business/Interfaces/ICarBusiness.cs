using System.Collections.Generic;
using TestandoConhecimento2.Model.Entities;

namespace TestandoConhecimento2.Business.Interfaces
{
    public interface ICarBusiness
    {
        Car Create(Car item);

        Car Update(Car item);

        void Delete(int id);

        Car GetById(int id);

        IList<Car> GetAll();

        bool Exists(int id);
    }
}
