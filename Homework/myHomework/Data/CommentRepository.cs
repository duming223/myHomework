using System;
using System.Collections.Generic;
using System.Text;
using myHomework._17HelpModel;

namespace myHomework.Data
{
    class CommentRepository<Comment> : IRepository<Comment>
    {
        IList<Comment> comments = new List<Comment>();
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
