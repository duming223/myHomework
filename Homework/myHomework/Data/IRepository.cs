using myHomework._17HelpModel;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace myHomework.Data
{
    public interface IRepository<T> where T : class
    {
        T Get();
        void Add(Article article);
        void Remove(Article article);
        void RemoveByAuthorName(string authorName);
        T OrderByPublishDate();
        T Search(string search);
        T GetByAuthorName(string authorName);
    }
}
