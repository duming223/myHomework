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

        #region old
        //private XMLRepository xMLRepository = new XMLRepository();
        //private string path = @"../../../XMLData";
        //private static XElement element;
        //private XDocument xDocument;
        //public List<Article> Articles { get; set; }
        //public List<Comment> Comments { get; set; }
        //public List<User> Users { get; set; }

        //public List<Article> GetByAuthorName(string authorName)
        //{
        //    XElement articles = XElement.Load(path + "/Articles.xml");
        //    XElement users = XElement.Load(path + "/Users.xml");
        //    var user = users.Descendants("User").Where(u => u.Element("name").Value == authorName).SingleOrDefault();
        //    var userId = user.Element("id").Value;
        //    var arts = articles.Descendants("article").Where(a => a.Element("authorId").Value == userId);
        //    //return arts;

        //    List<Article> list = new List<Article>();
        //    for (int i = 0; i < arts.Count(); i++)
        //    {
        //        foreach (var item in arts)
        //        {
        //            list[i].Id = Convert.ToInt32(item.Element("id").Value);
        //            list[i].Title = item.Element("title").Value;
        //            list[i].User.Id = Convert.ToInt32(item.Element("authorId").Value);
        //        }
        //    }
        //    return list;
        //} 
        #endregion

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

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}