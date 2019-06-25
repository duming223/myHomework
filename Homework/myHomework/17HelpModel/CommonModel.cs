using System;
using System.Collections.Generic;

namespace myHomework._17HelpModel
{
    /// <summary>
    /// 公共类
    /// </summary>
    public  class CommonModel
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime? PublishDate { get; set; }
        public User User { get; set; }
    }
}
