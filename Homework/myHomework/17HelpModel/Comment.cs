using myHomework.Data;
using System;
using System.Collections.Generic;

namespace myHomework._17HelpModel
{
    /// <summary>
    /// 评论
    /// </summary>
    public class Comment : CommonModel
    {
        private IRepository<Comment> _repComments;
        public Comment(Article article, string commentBody, User commentUser, IRepository<Comment> repository)
        {
            this.RefArticle = article;
            this.Body = commentBody;
            this.User = commentUser;
            this._repComments = repository;
        }
        //评论对应的文章
        public Article RefArticle { get; set; }
        public List<Agree> Agrees { get; set; }
        public List<DisAgree> DisAgrees { get; set; }
        public void Publish()
        {
            _repComments.Add(this);
            RefArticle.Comments.Add(this);
            Console.WriteLine($"{User.NickName}\t在文章《{RefArticle.ArticleTitle}》下发表了评论：{Body}.该文章共有{_repComments.Get().Count}条评论");
        }
    }
}