using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Collection
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        List<T> entities = new List<T>();
        public Repository()
        {  
        }
        public IEnumerable<T> GetAll()
        {
            return entities;
        }

        public T GetById(int id)
        {
            return entities.FirstOrDefault(p => p.id == id);
        }

        public void Add(T obj)
        {
            entities.Add(obj);
        }
        public void Update(T obj)
        {
          T find=entities.FirstOrDefault(p => p.id == obj.id);
            if (find != null)
            {
                find = obj;
            }
            else
                throw new Exception("Entity not found!");
        }
        public void Delete(int id)
        {
            var entity =entities.FirstOrDefault(p => p.id == id);
            entities.Remove(entity);
        }
      
    }
}
