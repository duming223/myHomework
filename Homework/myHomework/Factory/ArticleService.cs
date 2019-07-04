using myHomework._17HelpModel;
using myHomework.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace myHomework.Factory
{
    class ArticleFactory
    {
        private readonly IRepository<Article> _repository;
        public ArticleFactory(IRepository<Article> repository)
        {
            this._repository = repository;
        }
        public static void Init()
        {
            IRepository<Article> repository = new /*XMLRepository<Article>()*/XMLArticleRepository();
            ArticleFactory factory = new ArticleFactory(repository);
            factory.Make();
        }

        private void Make()
        {
            User user = new User("帕克");
            Article article = new Article("异步和并行", "被async标记的方法被称为异步方法...", user, new DateTime(2019, 6, 20));
            article.Publish();
            _repository.Add(article);
            _repository.Save();
        }
    }
}
