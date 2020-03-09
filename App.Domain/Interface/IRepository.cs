using App.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Insert(T item);
        T Update(T item);
        bool Delete(int id);
        T Select(int id);
        IEnumerable<T> Select();
    }
}
