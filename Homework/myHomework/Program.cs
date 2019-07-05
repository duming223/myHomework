using myHomework._17HelpModel;
using myHomework.Call;
using myHomework.Repository;
using System;
using System.Collections.Generic;
using System.IO;
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

            // Factory.ArticleFactory.Init();

            //ClearRepeatEmail.Call();

            TokenManager.Call();

            Console.ReadKey();
        }

    }
}
