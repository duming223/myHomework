using myHomework._17HelpModel;
using System.Collections.Generic;

namespace myHomework.Data
{
    public class ArticleRepository/*<Article> */: IRepository<Article>
    {
        IList<Article> articles = new List<Article>();
        public IList<Article> Get()
        {
            return articles;
        }
        public void Add(Article article)
        {
            articles.Add(article);
        }
        public void Remove(Article article)
        {
            articles.Remove(article);
        }

        public void RemoveByUser(User author)
        {

        }


    }
}
