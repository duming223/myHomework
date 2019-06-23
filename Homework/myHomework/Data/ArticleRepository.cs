using myHomework._17HelpModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace myHomework.Data
{
    public class ArticleRepository/*<Article> *//*: IRepository<Article>*/
    {
        public static IList<Article> articles;
        public IList<Article> Get()
        {
            return articles ?? new List<Article>();
        }
        public void Add(Article article)
        {
            articles = articles ?? new List<Article>();
            articles.Add(article);
        }
        public void Remove(Article article)
        {
            articles.Remove(article);
        }

        public IEnumerable<Article> GetByAuthorName(string authorName)
        {
            return articles.Where(a => a.User.NickName == authorName);
        }
        public IEnumerable<Article> OrderByPublishDate()
        {
            return from a in articles
                   orderby a.PublishDate descending
                   select a;
        }
        public void RemoveByAuthorName(string authorName)
        {
            var list = articles.Where(a => a.User.NickName == authorName);
            foreach (var article in list)
            {
                articles.Remove(article);
            }
        }

        public IEnumerable<Article> Search(string search)
        {
            return articles.Where(a =>
                      (a.Title.Contains(search)
                      || a.Body.Contains(search)));
        }
    }
}
