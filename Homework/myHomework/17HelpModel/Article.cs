using System;
using System.Collections.Generic;

namespace myHomework._17HelpModel
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article : CommonModel
    {
        public List<Agree> Agrees { get; set; }
        public List<Agree> DisAgrees { get; set; }
        public string Title { get; set; }
        public List<string> Keywords { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Article(string Title, string body, User author, DateTime? publishDate)
        {
            this.Title = Title;
            this.User = author;
            this.PublishDate = publishDate;
            this.Body = body;
        }
        public void Publish()
        {
            Console.WriteLine($"{User.NickName}\t在{PublishDate?.ToString("D")}发布了一篇标题为《{Title}》的文章");
        }
    }
}