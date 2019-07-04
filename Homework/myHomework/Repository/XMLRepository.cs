using myHomework._17HelpModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace myHomework.Repository
{
    public class XMLRepository<T> : IRepository<T>
    {
        public virtual void Add(T entity)
        {
            throw new NotImplementedException();
        }
        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> Get()
        {
            throw new Exception();
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }
    }
}