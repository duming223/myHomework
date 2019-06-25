using myHomework._17HelpModel;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace myHomework.Repository
{
    public interface IRepository<T> 
    {
        //IList<T> Get();
        //void Add(T article);
        //void Remove(T article);
        //void RemoveByAuthorName(string authorName);
        //IList<T> OrderByPublishDate();
        //IList<T> Search(string search);
        //IList<T> GetByAuthorName(string authorName);

        T Get(int id);
        List<T> Get();
        void Add(T entity);
        void Save();
    }
}
