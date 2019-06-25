using myHomework._17HelpModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace myHomework.Repository
{
    public class MemoryRepository<T> : IRepository<T>/*实现*/
    {
        public  void Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<T> Get()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}