using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Collection
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(int id);
       
    }
}
