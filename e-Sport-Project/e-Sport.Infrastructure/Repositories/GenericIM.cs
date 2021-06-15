using e_Sport.Domain.Interfaces;
using e_Sport.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace e_Sport.Infrastructure.Repositories
{
    public class GenericIM<T> : IRepository<T> where T : IEntity
    {
        protected List<T> instances;
        public void Add(T obj)
        {
            instances.Add(obj);
        }

        public T Find(int id)
        {
            return instances.Find(i => id == i.Id);
        }

        public T FindWhere(Predicate<T> cond)
        {
            return instances.Find(cond);
        }

        public IEnumerable<T> GetAll()
        {
            return instances;
        }

        public bool Remove(T obj)
        {
            return instances.Remove(obj);
        }
        public bool RemoveWhere(Predicate<T> cond)
        {
            return instances.RemoveAll(cond) > 0;
        }
    }
}
