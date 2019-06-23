using myHomework._17HelpModel;
using myHomework.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace myHomework.Services
{
    class XMLRepository : IRepository<XMLRepository>
    {
        private XMLRepository xMLRepository = new XMLRepository();
        private string path = @"../../../XMLData";
        private static XElement element;
        private XDocument xDocument;
        public List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }
        public List<User> Users { get; set; }

        public void Add(Article article)
        {
            path = path + "/Articles.xml";
            XElement xArt;
            XElement xel = new XElement("article",
                new XElement("id", article.Id),
                new XElement("title", article.Title),
                new XElement("authorId", article.User.Id)
                );
            if (Directory.Exists(path))
            {
                XElement.Load(path);
                xArt = xel;
            }
            else
            {
                xArt = new XElement("Articles", xel);
            }
            xDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), xArt);
        }
        public void Save()
        {
            xDocument.Save(path);
        }
        public XMLRepository Get()
        {
            List<Article> list = new List<Article>();
            var articles = XElement.Load(path + "/Users.xml").Descendants("article");

            for (int i = 0; i < articles.Count(); i++)
            {
                foreach (var item in articles)
                {
                    list[i].Id = Convert.ToInt32(item.Element("id").Value);
                    list[i].Title = item.Element("title").Value;
                    list[i].User.Id = Convert.ToInt32(item.Element("authorId").Value);
                    xMLRepository.Add(list[i]);
                }
            }
            return xMLRepository;
        }

        public void Remove(Article article)
        {
            throw new NotImplementedException();
        }

        public void RemoveByAuthorName(string authorName)
        {
            throw new NotImplementedException();
        }

        public XMLRepository OrderByPublishDate()
        {
            throw new NotImplementedException();
        }

        public XMLRepository Search(string search)
        {
            throw new NotImplementedException();
        }

        public XMLRepository GetByAuthorName(string authorName)
        {
            XElement articles = XElement.Load(path + "/Articles.xml");
            XElement users = XElement.Load(path + "/Users.xml");
            var user = users.Descendants("User").Where(u => u.Element("name").Value == authorName).SingleOrDefault();
            var userId = user.Element("id").Value;
            var arts = articles.Descendants("article").Where(a => a.Element("authorId").Value == userId);
            //return arts;

            List<Article> list = new List<Article>();
            for (int i = 0; i < arts.Count(); i++)
            {
                foreach (var item in arts)
                {
                    list[i].Id = Convert.ToInt32(item.Element("id").Value);
                    list[i].Title = item.Element("title").Value;
                    list[i].User.Id = Convert.ToInt32(item.Element("authorId").Value);
                    xMLRepository.Add(list[i]);
                }
            }
            return xMLRepository;
        }
    }
}
