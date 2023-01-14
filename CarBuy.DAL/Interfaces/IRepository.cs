using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuy.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetId(int id);
        void SaveItem(T entity);
        void Delete(int id);
    }
}
