using RestWithASPNET.Data.Converter.Implementations;
using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using RestWithASPNET.Repository;
using RestWithASPNET.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNET.Business.Implementations
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusiness(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public BookVO Create(BookVO book)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(book)));
        }

        public BookVO Update(BookVO book)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(book)));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }        
    }
}
