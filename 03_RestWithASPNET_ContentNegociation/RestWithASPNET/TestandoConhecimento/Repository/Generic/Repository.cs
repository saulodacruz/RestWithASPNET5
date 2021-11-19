using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TestandoConhecimento.Model.Context;
using TestandoConhecimento.Repository.Base;

namespace TestandoConhecimento.Repository.Generic
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private SQLContext _context;
        private DbSet<T> _dataSet;

        public Repository(SQLContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public T Create(T item)
        {
            _dataSet.Add(item);
            _context.SaveChanges();
            return item;
        }

        public T Update(T item)
        {
            _dataSet.Update(item);
            _context.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            var item = _dataSet.Find(id);
            _dataSet.Remove(item);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _dataSet.Find(id) != null;
        }

        public List<T> GetAll()
        {
            return _dataSet.ToList();
        }

        public T GetById(int id)
        {
            return _dataSet.Find(id);
        }     
    }
}
