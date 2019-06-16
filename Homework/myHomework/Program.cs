using myHomework._17HelpModel;
using myHomework.Call;
using myHomework.Data;
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
            wkCreateModel<Article>.Call();

            Console.ReadKey();
        }
    }
}
