using myHomework._17HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace myHomework.Data
{
    public interface IRepository<T>
    {
        IList<T> Get();
        void Add(T repository);
        void Remove(T repository);
        void RemoveByUser(User user);
    }
}
