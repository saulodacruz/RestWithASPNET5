using System.Collections.Generic;
using TestandoConhecimento.Model.Entities;

namespace TestandoConhecimento.Business.Interfaces
{
    public interface IBookBusiness
    {
        Book Create(Book item);

        Book Update(Book item);

        void Delete(int id);

        Book GetById(int id);

        List<Book> GetAll();

        bool Exists(int id);
    }
}
