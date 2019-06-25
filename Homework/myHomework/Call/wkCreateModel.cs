using myHomework._17HelpModel;
using myHomework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace myHomework.Call
{
    public static class wkCreateModel<T>
    {
        public static void Call()
        {
            //IRepository<Article> repArticle = new ArticleRepository/*<Article>*/();
            //IRepository<Comment> repComment = new CommentRepository/*<Comment>*/();

            //#region 一起帮建模
            //Console.WriteLine("-----------一起帮建模-----------");
            //User xy = new User("小鱼");
            //var articlesByxy = new List<Article>
            //{
            //    new Article(".Net平台", "提供了一个多语言组件开发和执行的环境....", xy, new DateTime(2018, 10, 5)/*, repArticle*/),
            //    new Article("C#基础", "敲出第一行代码Hello world!.....", xy, new DateTime(2019, 10, 5)/*, repArticle*/)
            //};
            //foreach (var article in articlesByxy)
            //{
            //    article.Publish();
            //    repArticle.Add(article);
            //}

            //Comment commentToN = new Comment(articlesByxy[0], "这几天真热啊", xy);
            //commentToN.Publish();

            //Problem problem = new Problem("vs安装错误", "如图错误", xy, true);
            //problem.Publish();

            //User commentUser = new User("小明");
            //Comment commentToC = new Comment(articlesByxy[1], "融化了", commentUser);
            //for (int i = 0; i < 4; i++)
            //{
            //    commentToC.Publish();
            //    repComment.Add(commentToC);
            //}

            //User fg = new User("飞哥");
            //var articlesByfg = new List<Article>
            //{
            //    new Article("泛型集合", "泛型集合使用场景.....", fg, new DateTime(2019, 3, 12)/*, repArticle*/),
            //    new Article("linq查询", "linq是C#独有的结果查询集......", fg, new DateTime(2018, 6, 12)/*, repArticle*/)
            //};
            //foreach (var article in articlesByfg)
            //{
            //    article.Publish();
            //    repArticle.Add(article);
            //}
            //var articles = repArticle.Get();
            //Console.WriteLine($"当前文章数量:{articles.Count()}");
            //#endregion

            //Console.WriteLine();
            //Console.WriteLine("----------Linq查询和Linq方法-----------");

            //var lsByfg = repArticle.GetByAuthorName("飞哥");
            //Console.WriteLine("飞哥发布的文章:");
            //foreach (var article in lsByfg)
            //{
            //    Console.WriteLine($"\t<{article.Title}>");
            //}
           
            //var lsByxy = articles.Where(
            //             a => a.User.NickName == "小鱼"
            //             && a.PublishDate > new DateTime(2019, 1, 1));
            //Console.WriteLine("小鱼 2019 - 1 - 1后发布的文章:");
            //foreach (var article in lsByxy)
            //{
            //    Console.WriteLine($"\t<{article.Title}>");
            //}

            //var aorderByTime = repArticle.OrderByPublishDate();
            //Console.WriteLine("发布文章按时间排序:");
            //foreach (var article in aorderByTime)
            //{
            //    Console.WriteLine($"\t<{article.Title}>发布时间:{article.PublishDate}");
            //}

            //var gas = articles.GroupBy(a => a.User);
            //foreach (var item in gas)
            //{
            //    Console.WriteLine($"{item.Key.NickName}发布的文章:");
            //    foreach (var i in item)
            //    {
            //        Console.WriteLine($"\t<{i.Title}>");
            //    }
            //}

            //var cas = repArticle.Search("C#");
            //Console.WriteLine("包含C#的文章:");
            //foreach (var item in cas)
            //{
            //    Console.WriteLine($"\t<{item.Title}>");
            //}

            //Console.WriteLine("用户最新发布的文章:");
            //var lastedArts = articles.GroupBy(u => u.User);
            //foreach (var item in lastedArts)
            //{
            //    Console.WriteLine($"{item.Key.NickName}:");
            //    var newItem = item.OrderByDescending(a => a.PublishDate).FirstOrDefault();
            //    Console.WriteLine($"<{newItem.Title}>- {newItem.PublishDate}");
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------每条文章下的评论------");
            //var gs = repComment.Get().GroupBy(a => a.RefArticle);
            //foreach (var item in gs)
            //{
            //    Console.WriteLine($"<{item.Key.Title}>的评论:");
            //    foreach (var c in item)
            //    {
            //        Console.WriteLine(c.Body);
            //    }
            //}

            //Console.WriteLine();
            //var query = from c in repComment.Get()
            //            group c by c.RefArticle into gc
            //            orderby gc.Count()
            //            select gc.Key;
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"<{item.Title}>");
            //}
        }
    }
}
