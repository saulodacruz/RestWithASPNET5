using System.Collections.Generic;
using TestandoConhecimento.Business.Interfaces;
using TestandoConhecimento.Model.Entities;
using TestandoConhecimento.Repository.Generic;

namespace TestandoConhecimento.Business.Implementations
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        public BookBusiness(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book item)
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

        public List<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Book GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Book Update(Book item)
        {
            return _repository.Update(item);
        }
    }
}
