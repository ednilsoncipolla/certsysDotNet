using App.Data.Context;
using App.Domain.Entity;
using App.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyContext _myContext;
        private DbSet<T> _dataset;

        public BaseRepository()
        {
            _myContext = new MyContext();
            _dataset = _myContext.Set<T>();
        }

        public bool Delete(int id)
        {
            try
            {
                var result = _dataset.SingleOrDefault(p => p.Id.Equals(id));

                if (result == null)
                    return false;

                _dataset.Remove(result);
                _myContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Insert(T item)
        {
            try
            {
                item.CreatedAt = DateTime.UtcNow;

                _dataset.Add(item);
                _myContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public T Select(int id)
        {
            try
            {
                return _dataset.SingleOrDefault(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> Select()
        {
            try
            {
                return _dataset.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Update(T item)
        {
            try
            {
                var result = _dataset.SingleOrDefault(p => p.Id.Equals(item.Id));

                if (result == null)
                    return null;

                item.UpdateAt = DateTime.UtcNow;

                _myContext.Entry(result).CurrentValues.SetValues(item);
                _myContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}
