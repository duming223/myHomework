using myHomework._17HelpModel;
using myHomework.Call;
using myHomework.Data;
using myHomework.Services;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //writeToXML.AddArticleToXML(article);
            Comment comment = new Comment(article, "灭霸吊炸天...", user);

            //writeToXML.AddCommentToXML(article, comment);

            //Console.WriteLine(WriteToXML.element);

            

            // writeToXML.AddUser(user);
            //writeToXML.AddArticle(article);
            //writeToXML.AddComment(article, comment);


            //add -> write
            Console.ReadKey();
        }

    }
}
