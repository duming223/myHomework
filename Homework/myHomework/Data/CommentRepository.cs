using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myHomework._17HelpModel;

namespace myHomework.Data
{
    public class CommentRepository/*<Comment>*/ /*: IRepository<Comment>*/
    {
        private static IList<Comment> comments;
        public void Add(Comment comment)
        {
            comments = comments ?? new List<Comment>();
            comments.Add(comment);
        }

        public IList<Comment> Get()
        {
            return comments ?? new List<Comment>();
        }

        public IEnumerable<Comment> GetByAuthorName(string authorName)
        {
            return comments.Where(c => c.User.NickName == authorName);
        }

        public IEnumerable<Comment> OrderByPublishDate()
        {
            return from c in comments
                   orderby c.PublishDate descending
                   select c;
        }

        public void Remove(Comment comment)
        {
            comments.Remove(comment);
        }

        public void RemoveByAuthorName(string authorName)
        {
            var list = comments.Where(c => c.User.NickName == authorName);
            foreach (var comment in list)
            {
                comments.Remove(comment);
            }
        }

        public IEnumerable<Comment> Search(string search)
        {
            return comments.Where(c => c.Body.Contains(search));
        }
    }
}
