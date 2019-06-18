using myHomework._17HelpModel;
using myHomework.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace myHomework.Call
{
    public static class wkCreateModel<T>
    {
        public static void Call()
        {
            IRepository<Article> repArticle = new ArticleRepository/*<Article>*/();
            IRepository<Comment> repComment = new CommentRepository/*<Comment>*/();
            var articles = repArticle.Get();

            #region 一起帮建模
            Console.WriteLine("-----------一起帮建模-----------");
            User xy = new User("小鱼");
            var articlesByxy = new List<Article>
            {
                new Article(".Net平台", "提供了一个多语言组件开发和执行的环境....", xy, new DateTime(2018, 10, 5), repArticle),
                new Article("C#基础", "敲出第一行代码Hello world!.....", xy, new DateTime(2019, 10, 5), repArticle)
            };
            foreach (var article in articlesByxy)
            {
                article.Publish();
            }

            Comment commentToN = new Comment(articlesByxy[0], "这几天真热啊", xy, repComment);
            commentToN.Publish();

            Problem problem = new Problem("vs安装错误", "如图错误", xy, true);
            problem.Publish();

            User commentUser = new User("小明");
            Comment commentToC = new Comment(articlesByxy[1], "融化了", commentUser, repComment);
            for (int i = 0; i < 5; i++)
            {
                commentToC.Publish();
            }


            User fg = new User("飞哥");
            var articlesByfg = new List<Article>
            {
                new Article("泛型集合", "泛型集合使用场景.....", fg, new DateTime(2019, 3, 12), repArticle),
                new Article("linq查询", "linq是C#独有的结果查询集......", fg, new DateTime(2018, 6, 12), repArticle)
            };
            foreach (var article in articlesByfg)
            {
                article.Publish();
            }

            Console.WriteLine($"当前文章数量:{articles.Count}");
            #endregion

            Console.WriteLine();
            Console.WriteLine("----------Linq查询和Linq方法-----------");
            //var lsByfg = from a in articles
            //             where (a.User.NickName == "飞哥")
            //             select a;
            var lsByfg = articles.Where(a => a.User.NickName == "飞哥");
            Console.WriteLine("飞哥发布的文章:");
            foreach (var article in lsByfg)
            {
                Console.WriteLine($"\t<{article.ArticleTitle}>");
            }

            //var lsByxy = from a in articles
            //             where (a.User.NickName == "小鱼" && a.PublishDate > new DateTime(2019, 1, 1))
            //             select a;
            var lsByxy = articles.Where(
                         a => a.User.NickName == "小鱼"
                         && a.PublishDate > new DateTime(2019, 1, 1));
            Console.WriteLine("小鱼 2019 - 1 - 1后发布的文章:");
            foreach (var article in lsByxy)
            {
                Console.WriteLine($"\t<{article.ArticleTitle}>");
            }

            //var aorderByTime = from r in articles
            //                   orderby r.PublishDate ascending
            //                   select r;
            var aorderByTime = articles.OrderBy(a => a.PublishDate);
            Console.WriteLine("发布文章按时间排序:");
            foreach (var article in aorderByTime)
            {
                Console.WriteLine($"\t<{article.ArticleTitle}>发布时间:{article.PublishDate}");
            }

            //var gas = from a in articles
            //          group a by a.User;
            var gas = articles.GroupBy(a => a.User);
            foreach (var item in gas)
            {
                Console.WriteLine($"{item.Key.NickName}发布的文章:");
                foreach (var i in item)
                {
                    Console.WriteLine($"\t<{i.ArticleTitle}>");
                }
            }

            //var cas = from a in articles
            //          where ((a.ArticleTitle.Contains("C#") || a.Body.Contains("C#")) || (a.ArticleTitle.Contains(".Net") || a.Body.Contains(".Net")))
            //          select a;
            var cas = articles.Where(a =>
                      (a.ArticleTitle.Contains("C#") || a.Body.Contains("C#"))
                     || (a.ArticleTitle.Contains(".Net") || a.Body.Contains(".Net")));
            Console.WriteLine("包含C#或.Net的文章:");
            foreach (var item in cas)
            {
                Console.WriteLine($"\t<{item.ArticleTitle}>");
            }

            Console.WriteLine("用户最新发布的文章:");
            var lastedArts = articles.GroupBy(u => u.User);
            foreach (var item in lastedArts)
            {
                Console.WriteLine($"{item.Key.NickName}:");
                var newItem = item.OrderByDescending(a => a.PublishDate).FirstOrDefault();
                Console.WriteLine($"{newItem.ArticleTitle}- {newItem.PublishDate}");
            }

            Console.WriteLine();
            Console.WriteLine("--------每条文章下的评论------");
            var gs = repComment.Get().GroupBy(a => a.RefArticle);
            foreach (var item in gs)
            {
                Console.WriteLine($"<{item.Key.ArticleTitle}>的评论:");
                foreach (var c in item)
                {
                    Console.WriteLine(c.Body);
                }
            }

            Console.WriteLine();
            var query = from c in repComment.Get()
                        group c by c.RefArticle into gc
                        orderby gc.Count()
                        select gc.Key;
            foreach (var item in query)
            {
                Console.WriteLine($"<{item.ArticleTitle}>");
            }
        }
    }
}
