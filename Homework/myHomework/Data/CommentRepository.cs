using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myHomework._17HelpModel;

namespace myHomework.Data
{
    public class CommentRepository/*<Comment>*/ : IRepository<Comment>
    {
        private IList<Comment> comments;

        public CommentRepository()
        {
            comments = new List<Comment>();
        }

        public void Add(Comment comment)
        {
            comments.Add(comment);
        }

        public IList<Comment> Get()
        {
            return comments;
        }

        public void Remove(Comment comment)
        {
            comments.Remove(comment);
        }

        public void RemoveByUser(User user)
        {

        }
    }
}
