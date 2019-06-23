using myHomework.Data;
using System;
using System.Collections.Generic;

namespace myHomework._17HelpModel
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article : CommonModel
    {
        public int Agree { get; set; }
        public int DisAgree { get; set; }
        public string Title { get; set; }
        public List<string> Keyword { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Article(string articleTitle, string body, User author, DateTime publishDate/*, IRepository<Article> repository*/)
        {
            this.Title = articleTitle;
            this.User = author;
            this.PublishDate = publishDate;
            this.Body = body;
            //this._repArticle = repository;
        }
        public void Publish()
        {
           // _repArticle.Add(this);
            Console.WriteLine($"{User.NickName}\t在{PublishDate.ToString("D")}发布了一篇标题为《{Title}》的文章");
        }
    }
}