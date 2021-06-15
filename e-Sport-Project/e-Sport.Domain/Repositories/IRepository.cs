using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Domain.Repositories
{
    public interface IRepository<T>
    {
        public void Add(T order);
        public bool Remove(T order);
        public IEnumerable<T> GetAll();
        public T Find(int id);
    }
}
