using myHomework._17HelpModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace myHomework.Repository
{
    class XMLArticleRepository : XMLRepository<Article>
    {
        private string path = @"../../../XMLData";
        private XDocument xDocument;
        public override void Add(Article article)
        {
            path = path + "/Articles.xml";
            XElement xArt;
            XElement xel = new XElement("Article",
               new XElement("id", article.Id),
               new XElement("title", article.Title),
               new XElement("authorId", article.User.Id)
               );
            if (Directory.Exists(path))
            {
                XElement element = XElement.Load(path);
                xArt = xel;
            }
            else
            {
                xArt = new XElement("Articles", xel);
            }
            xDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), xArt);
        }
        public override void Save()
        {
            xDocument.Save(path);
        }
        public User GetUser(string xAuthorId)
        {
            var xUserName = XElement.Load(path + "/Users.xml")
                .Descendants("User").Where(u => u.Element("id")
                .Value == xAuthorId).Select(n => n.Element("name").Value)
                .Single();
            User user = new User(xUserName);
            return user;
        }
        public override List<Article> Get()
        {
            List<Article> alist = new List<Article>();
            var xArticles = XElement.Load(path + "/Articles.xml").Descendants("Article");
            foreach (var xArt in xArticles)
            {
                string title = xArt.Element("title").Value;
                string body = xArt.Element("authorId").Value;
                User user = GetUser(xArt.Element("authorId").Value);
                DateTime? publishDate = null;
                Article article = new Article(title, body, user, publishDate);
                alist.Add(article);
            }
            return alist;
        }

        public List<Article> GetByAuthorName(string authorName)
        {
            IEnumerable<Article> list = Get().Where(u => u.User.NickName == authorName);
            return list.ToList();
        }
    }
}
