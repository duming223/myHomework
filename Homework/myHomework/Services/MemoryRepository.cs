using myHomework._17HelpModel;
using System.Collections.Generic;

namespace myHomework.Services
{
    public class MemoryRepository
    {
        public List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }
        public List<User> Users { get; set; }

    }
}