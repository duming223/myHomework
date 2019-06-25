using myHomework._17HelpModel;
using myHomework.Repository;
using System;

namespace myHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //一起帮建模
            // wkCreateModel<Article>.Call();

            //Linq to XML
            //wkXML.CreateXML();

            User user = new User("钢铁侠");
            Article article = new Article("多线程", "灭霸来袭....", user, new DateTime(2023, 2, 5));
            Comment comment = new Comment(article, "灭霸吊炸天...", user);

            Factory.ArticleFactory.Init();

            Console.ReadKey();
        }

    }
}
